using System.Text;

namespace CalendarCreate
{
    public class HTMLBuilder
    {
        private FileStream _fs;
        public HTMLBuilder(FileStream fs)
        {
            if (null != fs)
            {
                _fs = fs;
            }
        }

        public int CreateHeader()
        {
            if (null != _fs)
            {
                while (!_fs.CanWrite) { }/* TODO - Possible endless loop */

                #region HTML
                const string html = "<!DOCTYPE html>\r\n<html>\r\n    <head>\r\n        <title>DFitzgerald Calendar Create</title>\r\n\r\n        <style>\r\n            body {background-color:#ffffff;background-repeat:no-repeat;background-position:top left;background-attachment:fixed;}\r\n            h1{font-family:Arial, sans-serif;color:#000000;background-color:#ffffff;}\r\n            p {font-family:Georgia, serif;font-size:14px;font-style:normal;font-weight:normal;color:#000000;background-color:#ffffff;}\r\n        </style>\r\n\r\n        <style>\r\n            table.GeneratedTable {\r\n              width: 100%;\r\n              background-color: #ffffff;\r\n              border-collapse: collapse;\r\n              border-width: 2px;\r\n              border-color: #ffcc00;\r\n              border-style: solid;\r\n              color: #000000;\r\n            }\r\n\r\n            table.GeneratedTable td, table.GeneratedTable th {\r\n              border-width: 2px;\r\n              border-color: #ffcc00;\r\n              border-style: solid;\r\n              padding: 3px;\r\n            }\r\n\r\n            table.GeneratedTable thead {\r\n              background-color: #ffcc00;\r\n            }\r\n        </style>\r\n    </head>\r\n\r\n    <body>";
                #endregion

                /* The header must appear at the start of the file! */
                _fs.Position = 0;

                /* Get byte array from header string - ASCII */
                byte[] encodedBytes = Encoding.ASCII.GetBytes(html);

                _fs.Write(encodedBytes, (int)_fs.Position, encodedBytes.Length);

                return 0;
            }
            else
            {
                return ErrorHandler.HandleError(ErrorHandler.eERRORS.FILE_ACCESS);
            }
        }
        public int CreateFooter()
        {
            if (null != _fs)
            {
                while (!_fs.CanWrite) { }/* TODO - Possible endless loop */

                #region HTML
                const string html = "    </body>\r\n</html>";
                #endregion

                /* Get byte array from footer string - ASCII */
                byte[] encodedBytes = Encoding.ASCII.GetBytes(html);
                _fs.Write(encodedBytes);

                return 0;
            }
            else
            {
                return ErrorHandler.HandleError(ErrorHandler.eERRORS.FILE_ACCESS);
            }
        }

        public int CreateDocTitle(string title)
        {
            if (null != _fs)
            {
                while (!_fs.CanWrite) { }/* TODO - Possible endless loop */

                byte[] encodedBytes = Encoding.ASCII.GetBytes("<h1>"+title+"</h1>");
                _fs.Write(encodedBytes);

                return 0;
            }
            else
            {
                return ErrorHandler.HandleError(ErrorHandler.eERRORS.FILE_ACCESS);
            }
        }

        public int CreateDocTable(string title, int[] days)
        {
            if (null != _fs)
            {
                while (!_fs.CanWrite) { }/* TODO - Possible endless loop */

                ushort colCount = 7;
                ushort rowCount = (ushort)Math.Ceiling((double)((double)days.Length / (double)colCount));
                ushort daysIndex = 0;

                byte[] encodedBytes;

                /* Set table style */
                encodedBytes = Encoding.ASCII.GetBytes("<style>\r\ntable{border: 1px solid black}\r\ntable td{border: 1px solid black}\r\n</style>");
                _fs.Write(encodedBytes);

                /* Write table header */
                encodedBytes = Encoding.ASCII.GetBytes("<table style=\"width: 100px\">");
                _fs.Write(encodedBytes);

                /* Write table title */
                encodedBytes = Encoding.ASCII.GetBytes("<thead>\r\n<tr>\r\n<th colspan=\""+(colCount+1).ToString()+"\" bgcolor=\"#CCFFCC\">" + title+"</th>\r\n</tr>\r\n</thead>");
                _fs.Write(encodedBytes);

                /* Write table body */
                encodedBytes = Encoding.ASCII.GetBytes("<tbody>");
                _fs.Write(encodedBytes);

                for (ushort row = 0; row < rowCount; row++)
                {
                    /* Create column headers */
                    if(0 == row)
                    {
                        /* Write table row */
                        encodedBytes = Encoding.ASCII.GetBytes("<tr>");
                        _fs.Write(encodedBytes);
                        
                        encodedBytes = Encoding.ASCII.GetBytes("<td bgcolor=\"#E6E6E6\">Wk</td>");
                        _fs.Write(encodedBytes);
                        encodedBytes = Encoding.ASCII.GetBytes("<td bgcolor=\"#E6E6E6\">Mo</td>");
                        _fs.Write(encodedBytes);
                        encodedBytes = Encoding.ASCII.GetBytes("<td bgcolor=\"#E6E6E6\">Tu</td>");
                        _fs.Write(encodedBytes);
                        encodedBytes = Encoding.ASCII.GetBytes("<td bgcolor=\"#E6E6E6\">We</td>");
                        _fs.Write(encodedBytes);
                        encodedBytes = Encoding.ASCII.GetBytes("<td bgcolor=\"#E6E6E6\">Th</td>");
                        _fs.Write(encodedBytes);
                        encodedBytes = Encoding.ASCII.GetBytes("<td bgcolor=\"#E6E6E6\">Fr</td>");
                        _fs.Write(encodedBytes);
                        encodedBytes = Encoding.ASCII.GetBytes("<td bgcolor=\"#FFFFCC\">Sa</td>");
                        _fs.Write(encodedBytes);
                        encodedBytes = Encoding.ASCII.GetBytes("<td bgcolor=\"#FFCC99\">Su</td>");
                        _fs.Write(encodedBytes);

                        /* Write table row end */
                        encodedBytes = Encoding.ASCII.GetBytes("</tr>");
                        _fs.Write(encodedBytes);
                    }

                    /* Write table row */
                    encodedBytes = Encoding.ASCII.GetBytes("<tr>");
                    _fs.Write(encodedBytes);

                    for (ushort col = 0; col < colCount+1; col++)
                    {
                        if (0 == col)
                        {
                            /* Write WK num entry */
                            encodedBytes = Encoding.ASCII.GetBytes("<td bgcolor=\"#E6E6E6\"></td>");
                            _fs.Write(encodedBytes);
                        }
                        else
                        {
                            /* Write col entry */
                            if (6 == col)
                            {
                                encodedBytes = Encoding.ASCII.GetBytes("<td bgcolor=\"#FFFFCC\">" + (++daysIndex).ToString() + "</td>");
                            }
                            else if(7 == col)
                            {
                                encodedBytes = Encoding.ASCII.GetBytes("<td bgcolor=\"#FFCC99\">" + (++daysIndex).ToString() + "</td>");
                            }
                            else
                            {
                                encodedBytes = Encoding.ASCII.GetBytes("<td>" + (++daysIndex).ToString() + "</td>");
                            }
                            _fs.Write(encodedBytes);
                        }
                        if(daysIndex >= days.Length){ break; }
                    }
                    
                    /* Write table row end */
                    encodedBytes = Encoding.ASCII.GetBytes("</tr>");
                    _fs.Write(encodedBytes);

                    if (daysIndex >= days.Length) { break; }
                }

                /* Write table body end */
                encodedBytes = Encoding.ASCII.GetBytes("</tbody>");
                _fs.Write(encodedBytes);

                /* Write table footer */
                encodedBytes = Encoding.ASCII.GetBytes("</table>");
                _fs.Write(encodedBytes);

                return 0;
            }
            else
            {
                return ErrorHandler.HandleError(ErrorHandler.eERRORS.FILE_ACCESS);
            }
        }
    }
}
