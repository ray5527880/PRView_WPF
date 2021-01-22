using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using BF_FW;
using BF_FW.data;
using GSF.COMTRADE;

namespace PRView.Model
{
    public class MainWindowModel
    {
        public enum OpenFileErorCode
        {
            Null=0,
            NotDatFile=1
        }
        public MainWindowModel()
        {

        }
        public OpenFileErorCode OpenFile(string FilePaht,string FileName)
        {
            //setEnable(false);

            string strFile = FilePaht;
            string strRarPath = string.Empty;
            string strFileName = FileName;
            string strXmlFile = this.GetType().Assembly.Location;
            string strfilePath = strXmlFile = strXmlFile.Replace("PRView.exe", "CompressFile\\");
            if (strFile.IndexOf(".cfg") > 0 || strFile.IndexOf(".CFG") > 0)
            {
                if (File.Exists(strFile.Replace(".cfg", ".dat")) || File.Exists(strFile.Replace(".CFG", ".DAT")))
                {
                    Directory.CreateDirectory(strfilePath);
                    File.Copy(strFile, (strfilePath + strFileName), true);
                    File.Copy(strFile.Replace(".cfg", ".dat"), strfilePath + strFileName.Replace(".cfg", ".dat"), true);
                    File.Copy(strFile.Replace(".CFG", ".DAT"), strfilePath + strFileName.Replace(".CFG", ".DAT"), true);
                }
                else                
                    return OpenFileErorCode.NotDatFile;                
            }
            else
            {
                while (strFile.IndexOf(@"\") > -1)
                {
                    strRarPath += strFile.Substring(0, strFile.IndexOf(@"\") + 1);
                    strFile = strFile.Substring(strFile.IndexOf(@"\") + 1);
                }
                var mCompressWinRAR = new CompressWinRAR();
                mCompressWinRAR.UnCompressRar(strfilePath, strRarPath, strFile);
            }
            Parser parser = new Parser();
            //try
            //{
            //    foreach (var item in Directory.GetFiles(strfilePath, "*.cfg"))
            //    {
            //        LoadDataFile.GetCFGData(item, ref mParser);
            //        break;
            //    }
            //    foreach (var item in Directory.GetFiles(strfilePath, "*.CFG"))
            //    {
            //        LoadDataFile.GetCFGData(item, ref mParser);
            //        break;
            //    }
            //    PData = new List<double[]>();
            //    SData = new List<double[]>();
            //    PUData = new List<double[]>();
            //    LoadDataFile.GetDatData(mParser, ref PData, ref SData, ref PUData);

            //    Set_Information();

            //    List<int> _fftIndex = new List<int>();
            //    for (int i = 0; i < mParser.Schema.TotalAnalogChannels; i++)
            //    {
            //        if (mParser.Schema.AnalogChannels[i].Units == "V" || mParser.Schema.AnalogChannels[i].Units == "A")
            //            _fftIndex.Add(i);
            //    }
            //    FFTIndex = _fftIndex.ToArray();

            //    ClearButton();
            //    for (int i = 0; i < mParser.Schema.TotalAnalogChannels; i++)
            //    {
            //        AddNewButton(mParser.Schema.AnalogChannels[i].Name, i, 0);
            //    }
            //    for (int i = 0; i < mParser.Schema.TotalDigitalChannels; i++)
            //    {
            //        AddNewButton(mParser.Schema.DigitalChannels[i].Name, i, 1);
            //    }
            //    for (int i = 0; i < FFTIndex.Length; i++)
            //    {
            //        AddNewButton(mParser.Schema.AnalogChannels[FFTIndex[i]].Name + "_FFT", i + mParser.Schema.TotalAnalogChannels, 0);
            //    }
            //    cbxPS.Items.Add("P");
            //    cbxPS.Items.Add("S");
            //    cbxPS.Items.Add("Per Unit");

            //    cbxPS.SelectedIndex = 1;
            //    sizeChanged();
            //}
            //catch (ApplicationException message)
            //{
            //    MessageBox.Show(String.Format("{0}: {1}", strFile, message.Message));
            //}
            //finally
            //{
            //    setEnable(true);
            //}
            return OpenFileErorCode.Null;
        }
    }
}
