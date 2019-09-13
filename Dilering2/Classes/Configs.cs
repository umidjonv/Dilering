using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Classes.DB;
using tposDesktop;
using tposDesktop.DataSetTposTableAdapters;
namespace Classes
{
    public class Configs
    {
        public Configs()
        {
            GetRow("currentFaktura");
        }
        
        public static void UpdateConfig(string name)
        {
            configsTableAdapter cfda = new configsTableAdapter();
            cfda.Update(GetRow(name));
            GetRow(name);
        }

        private static void UpdateConfig(DataSetTpos.configsRow cfg)
        {
            string cfgName = cfg.configName;
            configsTableAdapter cfda = new configsTableAdapter();
            cfda.Update(cfg);
            GetRow(cfgName);
        }

        public static string GetConfig(string name)
        {
            string configVal = "";
            switch (name)
            {
                case "currentFaktura":
                    configVal = GetRow(name).configValue;
                    break;
                case "openday":
                    configVal = GetRow(name).configValue;
                    break;
                case "CashCharge":
                case "TerminalCharge":
                case "TransferCharge":
                case "OtherCharge":
                    configVal = GetRow(name).configValue;

                    break;  
            }
            return configVal;
        }

        static DataSetTpos.configsRow GetRow(string name)
        {
            DataSetTpos.configsRow cfgRow = null;
            switch (name)
            {
                case "currentFaktura":
                    if (fakturaRow != null&&fakturaRow.RowState!= DataRowState.Detached) cfgRow = fakturaRow;
                    else
                    {
                        DataRow[] drs = DBclass.DS.configs.Select("configName = 'currentFaktura'");
                        if (drs.Length > 0)
                        {
                            currentFaktura = int.Parse(drs[0]["configValue"].ToString());
                            fakturaRow = (DataSetTpos.configsRow)drs[0];
                        }
                        else
                        {
                            DataSetTpos.configsRow cfRow = DBclass.DS.configs.NewconfigsRow();
                            cfRow.configName = "currentFaktura";
                            cfRow.configValue = "0";
                            fakturaRow = cfRow;
                            DBclass.DS.configs.AddconfigsRow(cfRow);
                            //UpdateConfig("currentFaktura");
                        }
                        cfgRow = fakturaRow;
                    }
                    break;
                case "openday":
                    if (fakturaRow != null) cfgRow = fakturaRow;
                    else
                    {
                        DataRow[] drs = DBclass.DS.configs.Select("configName = 'openday'");
                        if (drs.Length > 0)
                        {
                            currentFaktura = int.Parse(drs[0]["configValue"].ToString());
                            fakturaRow = (DataSetTpos.configsRow)drs[0];
                        }
                        else
                        {
                            DataSetTpos.configsRow cfRow = DBclass.DS.configs.NewconfigsRow();
                            cfRow.configName = "openday";
                            cfRow.configValue = "0";
                            fakturaRow = cfRow;
                            DBclass.DS.configs.AddconfigsRow(cfRow);
                            //UpdateConfig("currentFaktura");
                        }
                        cfgRow = fakturaRow;
                    }
                    break;
                case "CashCharge":
                case "TerminalCharge":
                case "TransferCharge":
                case "OtherCharge":
                    DataSetTpos.configsRow[] conf = (DataSetTpos.configsRow[])DBclass.DS.configs.Select("configName = '" + name + "'");
                        if (conf.Length>0)
                        {
                            cfgRow = conf[0];
                            
                        }
                        else
                        {
                            DataSetTpos.configsRow cfRow = DBclass.DS.configs.NewconfigsRow();
                            cfRow.configName = name;
                            cfRow.configValue = "0";
                            
                            DBclass.DS.configs.AddconfigsRow(cfRow);
                            UpdateConfig(cfRow);

                            cfgRow = DBclass.DS.configs.Last<DataSetTpos.configsRow>();
                            
                        }
                        
                    
                    break;
            }
            
            return cfgRow;
            
        }



        public static void SetConfig(string name, string value)
        {
            DataSetTpos.configsRow cfgRow = null;
            DataRow[] drs ;
            switch (name)
            {
                case "currentFaktura":
                    
                        drs = DBclass.DS.configs.Select("configName = 'currentFaktura'");
                        if (drs.Length > 0)
                        {
                            drs[0]["configValue"] = value;
                            fakturaRow = (DataSetTpos.configsRow)drs[0];
                            UpdateConfig(fakturaRow);
                        }
                        else
                        {
                            DataSetTpos.configsRow cfRow = DBclass.DS.configs.NewconfigsRow();
                            cfRow.configName = "currentFaktura";
                            cfRow.configValue = "0";
                            fakturaRow = cfRow;
                            DBclass.DS.configs.AddconfigsRow(cfRow);
                            UpdateConfig(cfRow);
                        }
                        cfgRow = fakturaRow;
                    
                    break;
                case "openday":

                    drs = DBclass.DS.configs.Select("configName = 'openday'");
                    if (drs.Length > 0)
                    {
                        drs[0]["configValue"] = value;
                        fakturaRow = (DataSetTpos.configsRow)drs[0];
                        UpdateConfig(fakturaRow);
                    }
                    else
                    {
                        DataSetTpos.configsRow cfRow = DBclass.DS.configs.NewconfigsRow();
                        cfRow.configName = "openday";
                        cfRow.configValue = "0";
                        fakturaRow = cfRow;
                        DBclass.DS.configs.AddconfigsRow(cfRow);
                        UpdateConfig(cfRow);
                    }
                    cfgRow = fakturaRow;

                    break;
                default:
                     DataSetTpos.configsRow[] conf = (DataSetTpos.configsRow[])DBclass.DS.configs.Select("configName = '" + name + "'");
                     if (conf.Length > 0)
                     {
                         conf[0].configValue = value;
                         UpdateConfig(conf[0]);
                     }
                    break;
            }

            

        }
        static DataSetTpos.configsRow fakturaRow;
        public static int currentFaktura = 0;

    }
}
