namespace drg_group.changzhou_2022{
    public class RA2
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"C45.900","C46.100","C46.300","C46.900","C46.900x002","C46.900x003","C46.900x004","C48.103","C48.104","C48.105","C48.200","C48.201","C49.901","C77.202","C77.205","C77.300","C77.300x001","C77.300x003","C77.301","C77.303","C77.400x001","C77.401","C77.501","C77.502","C77.503","C77.800","C77.900","C77.900x001","C78.601","C79.800x804","C79.800x809","C79.800x811","C79.800x816","C79.800x817","C79.800x818","C79.800x834","C79.800x837","C79.800x838","C79.807","C79.809","C79.811","C79.821","C79.900x001","C80.900","C81.000","C81.100","C81.200","C81.300","C81.700","C81.701","C81.702","C81.703","C81.900","C81.900x005","C82.000","C82.100","C82.200","C82.500","C82.600","C82.700","C82.701","C82.702","C82.703","C82.704","C82.900","C82.901","C83.000","C83.002","C83.003","C83.100","C83.101","C83.102","C83.300","C83.300x006","C83.300x007","C83.300x008","C83.300x009","C83.301","C83.303","C83.304","C83.306","C83.500","C83.501","C83.503","C83.505","C83.700","C83.800","C83.800x006","C83.800x008","C83.800x009","C83.801","C83.802","C83.900","C84.000","C84.000x002","C84.000x003","C84.100","C84.400","C84.401","C84.402","C84.403","C84.404","C84.405","C84.406","C84.407","C84.500","C84.500x004","C84.500x012","C84.500x016","C84.502","C84.600","C84.700","C84.800","C85.100","C85.100x010","C85.100x017","C85.100x021","C85.200","C85.700","C85.700x004","C85.700x016","C85.701","C85.704","C85.705","C85.707","C85.709","C85.715","C85.900","C85.900x001","C85.900x002","C85.900x003","C85.900x004","C85.900x005","C85.900x006","C85.900x008","C85.900x009","C85.900x010","C85.900x011","C85.900x012","C85.900x013","C85.900x014","C85.900x015","C85.900x016","C85.900x017","C85.900x019","C85.900x020","C85.900x022","C85.900x023","C85.900x024","C85.900x025","C85.900x026","C85.900x027","C85.900x028","C85.900x029","C85.900x030","C85.900x031","C85.900x034","C85.900x036","C85.900x037","C85.900x040","C85.900x041","C85.900x042","C85.900x043","C85.901","C86.000","C86.100","C86.200","C86.300","C86.600","C86.602","C86.603","C88.000","C88.000x002","C88.000x011","C88.000x012","C88.200x011","C88.200x012","C88.201","C88.202","C88.203","C88.300","C88.301","C88.302","C88.400","C88.401","C88.402","C88.403","C88.700","C88.700x002","C88.700x003","C88.700x012","C88.700x013","C88.701","C88.900","C88.900x001","C90.100","C90.100x002","C90.100x011","C91.000","C91.000x006","C91.000x006","C91.000x007","C91.000x009","C91.000x012","C91.000x013","C91.000x014","C91.000x015","C91.000x016","C91.000x017","C91.001","C91.002","C91.003","C91.004","C91.006","C91.007","C91.008","C91.100","C91.100x011","C91.100x012","C91.101","C91.102","C91.300","C91.400","C91.400x004","C91.400x013","C91.401","C91.500","C91.500x011","C91.600","C91.700","C91.701","C91.800","C91.900","C91.901","C92.000","C92.000x003","C92.000x006","C92.000x011","C92.000x012","C92.000x013","C92.000x014","C92.000x015","C92.000x016","C92.000x017","C92.000x018","C92.001","C92.002","C92.003","C92.004","C92.005","C92.006","C92.007","C92.100","C92.100x001","C92.100x002","C92.100x004","C92.100x011","C92.100x012","C92.100x014","C92.100x016","C92.100x017","C92.100x018","C92.100x019","C92.101","C92.102","C92.103","C92.200","C92.200x001","C92.200x011","C92.201","C92.300","C92.300x001","C92.300x003","C92.300x011","C92.300x013","C92.400x011","C92.401","C92.402","C92.403","C92.500x011","C92.501","C92.502","C92.600","C92.601","C92.700","C92.700x006","C92.700x012","C92.700x013","C92.701","C92.703","C92.706","C92.900","C92.900x001","C92.900x011","C92.901","C93.000x011","C93.000x016","C93.001","C93.002","C93.003","C93.100","C93.100x011","C93.100x012","C93.100x013","C93.101","C93.102","C93.103","C93.300","C93.300x001","C93.700","C93.701","C93.900","C93.901","C94.000x001","C94.000x011","C94.001","C94.004","C94.200","C94.200x011","C94.201","C94.202","C94.300","C94.300x011","C94.400","C94.400x001","C94.700","C94.700x004","C94.700x014","C94.703","C95.000","C95.000x002","C95.000x003","C95.000x015","C95.000x016","C95.000x017","C95.000x018","C95.000x101","C95.000x102","C95.000x115","C95.000x116","C95.000x117","C95.000x118","C95.002","C95.003","C95.004","C95.005","C95.006","C95.100","C95.100x011","C95.700x001","C95.700x002","C95.700x003","C95.700x011","C95.900","C95.900x003+M36.1*","C95.900x005","C95.900x012","C95.900x013+M36.1*","C95.900x015","C95.901","C96.002","C96.004","C96.200","C96.200x005","C96.200x006","C96.200x013","C96.202","C96.400","C96.400x001","C96.400x002","C96.400x003","C96.400x004","C96.401","C96.402","C96.700","C96.704","C96.705","C96.800","C96.801","C96.900","D45.x00","D47.100x019","D47.101"};
            String[] adrg_zd1={};
            String[] adrg_ss={"01.1200","01.1400","01.2400x005","01.2400x009","01.2400x013","01.2400x018","01.2402","01.2405","01.2407","01.2413","01.2414","01.2415","02.0101","02.0102","02.0201","02.0202","02.0203","02.0300x001","02.0400x003","02.0500x004","02.0500x005","02.0502","02.0600x003","02.0700","03.3201","03.3202","03.4x00x002","03.4x00x004","03.4x03","07.1600","25.0200","25.1x01","25.1x02","25.1x03","25.1x04","25.1x05","25.2x00","25.2x01","26.1200x001","26.1200x002","32.2400x001","32.2500x001","33.2000","33.2000x002","33.2400x001","33.2400x002","33.2400x002","33.2400x002","33.2402","33.2403","33.2405","33.2500x002","33.2500x003","33.2600x001","33.2600x002","33.2800x001","34.2000","34.2300","34.2400x001","34.2500","34.2501","34.2502","34.2600","34.2700x001","34.9101","34.9102","34.9103","37.2400","37.2401","37.2500x001","37.9100","38.2100","38.8605","39.7900x017","39.9800x001","39.9801","40.1100x003","40.1100x004","40.2900x002","40.2900x019","40.2900x020","40.2904","40.2906","40.2908","40.2910","41.1x00","41.3200x001","41.3300","41.4200x003","41.9100x001","41.9200","41.9201","41.9202","41.9203","42.1100","42.1200","42.1901","42.2100","42.2200","42.2500","42.3200x003","42.3201","42.3300x006","42.3301","42.3303","42.3305","42.3306","42.3309","43.0x00x003","43.0x02","43.1100x001","43.1900x003","43.1900x005","43.4100x011","43.4100x013","43.4100x014","43.4100x015","43.4100x016","43.4101","44.1500","45.1101","45.1200x001","45.3001","45.3004","45.3005","45.3007","45.3400x002","45.3400x003","45.3400x004","45.4200x003","45.4201","45.4300x008","45.4300x009","45.4300x012","45.4302","45.4304","45.4307","46.0401","46.0402","46.1000","46.1000x007","46.1100","46.1100x002","46.1300","46.1301","46.1400","46.2100","46.2300x001","46.2301","46.2400","46.3200x002","46.3900x002","46.3900x006","46.3900x007","46.3901","46.3902","46.3904","46.3905","46.4100","46.4101","46.4102","46.4103","46.8600","48.3507","48.3600x002","48.3600x003","48.3600x004","48.3600x006","48.3600x007","50.1100x001","50.1100x005","50.1200","50.1400","50.2301","50.2302","50.2303","50.2401","50.2402","50.2403","50.2404","50.2502","50.2900x020","50.2902","50.2904","50.2905","50.2908","50.2909","50.6101","50.6900x002","50.6901","50.9401","50.9402","50.9900x003","51.1301","51.1302","51.8400x001","51.8500x002","51.8501","51.8502","51.8503","51.8600x002","51.8700x001","51.8700x003","51.8700x004","51.9100","51.9200","51.9501","51.9600x001","51.9800x001","51.9800x005","51.9800x008","51.9800x009","51.9800x010","51.9800x012","51.9800x013","51.9800x015","51.9800x016","51.9801","51.9806","51.9807","51.9808","51.9901","52.1200","52.9201","52.9300","52.9300x002","52.9400","52.9400x002","54.0x00x002","54.0x00x004","54.0x00x006","54.0x00x010","54.0x00x013","54.0x00x018","54.0x00x021","54.0x00x022","54.0x00x023","54.0x00x024","54.0x00x025","54.0x01","54.0x02","54.0x03","54.0x04","54.0x05","54.0x06","54.0x07","54.0x08","54.1100","54.2100","54.2100x005","54.2200x003","54.2201","54.2202","54.2300x003","54.2300x004","54.2300x005","54.2300x006","54.2301","54.2302","54.2303","54.2400x001","54.2400x002","54.2400x003","54.2400x006","54.2401","54.2403","54.2404","54.2500x001","54.3x00x004","54.3x00x010","54.3x00x011","54.3x00x027","54.3x01","54.3x02","54.3x03","54.3x04","54.3x05","54.4x02","54.6101","54.6301","54.6400","54.6401","54.7100","54.7200x001","54.9100x002","54.9100x009","54.9101","54.9104","54.9300x001","55.3301","55.3302","56.4100x012","56.5101","56.5102","56.5200x001","56.6100x001","56.6100x003","56.6100x004","56.7100x002","56.7100x004","56.7300","56.7402","56.7501","56.8100","56.8200x002","56.8201","56.8300","56.8400x001","56.8401","56.8500","56.8600","57.1200","57.1901","57.1902","57.1903","57.1905","57.2100","57.4100x002","57.8200","57.8900x003","57.8900x004","57.8903","57.9102","57.9201","57.9600","57.9900x001","58.0x00x003","58.0x01","58.0x02","58.1x01","58.3101","58.3103","58.3901","58.3902","58.3903","58.3904","58.3905","58.3906","58.4301","58.4302","58.4303","58.4304","58.4305","58.9102","58.9200x002","58.9201","58.9300","58.9901","59.0000","59.0201","59.0202","59.0203","59.0301","59.0302","59.0303","59.0901","59.0902","59.0903","59.1901","59.1902","60.2100x001","60.2900x003","60.2901","60.2902","60.6100x001","60.6100x002","60.6101","60.6200","60.6201","60.6900x001","60.6900x002","65.1100","65.1200x001","65.1201","65.1300","67.2x00","67.2x01","67.3904","67.4x08","68.1300","68.1400","68.1501","68.1601","68.2903","68.2915","68.2917","71.2400x003","86.1100"};
            String[] adrg_ss1={};
            
            if (true && adrg_zd.Contains(record.zdList[0]) && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合RA2入组条件，匹配规则：主诊断匹配、主手术匹配");
                    
                if (MDCR_DRG.RA21_group(record))
                {
                    return "RA21";
                }
    
                if (MDCR_DRG.RA23_group(record))
                {
                    return "RA23";
                }
    
                if (MDCR_DRG.RA25_group(record))
                {
                    return "RA25";
                }

                return "RA2";
            }else{
                return "";
            }
        }
    }
}