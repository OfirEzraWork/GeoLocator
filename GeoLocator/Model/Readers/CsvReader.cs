using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoLocator
{
    class CsvReader : FileReader
    {
        private List<Location> locations;
        private bool containsRecords;
        public bool ContainsRecords()
        {
            return containsRecords;
        }
        public CsvReader()
        {
            locations = new List<Location>();
            containsRecords = false;
        }

        public List<Location> GetLocations()
        {
            return locations;
        }

        public void ReadFile(string path)
        {
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    try
                    {
                        using (TextFieldParser csvParser = new TextFieldParser(path))
                        {
                            csvParser.SetDelimiters(new string[] { ";" });

                            //assumes the file does not contain column names

                            while (!csvParser.EndOfData)
                            {
                                // Read current line fields, pointer moves to the next line.
                                string[] fields = csvParser.ReadFields();
                                locations.Add(new Location(DateTime.Parse(fields[0]), fields[1], fields[2]));
                            }
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        MessageBox.Show("CSV Contains less than three columns", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    catch
                    {
                        MessageBox.Show("Error reading the source CSV file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File wasn't found.\nPlease enter a valid path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("Directory wasn't found.\nPlease enter a valid path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //catch (ArgumentException)
            //{
            //    MessageBox.Show("Please enter a valid path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    check = false;
            //}
            catch (Exception)
            {
                MessageBox.Show("Failed because of an unknown exception", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            containsRecords = true;

        }
    }
}
