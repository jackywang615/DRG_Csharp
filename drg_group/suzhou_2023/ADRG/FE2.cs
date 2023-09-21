namespace drg_group.suzhou_2023{
    public class FE2 
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_ss={"38.0400x001","38.0400x002","38.0401","38.0502","38.0503","38.0504","38.0702","38.1400x001","38.1401","38.1402","38.1403","38.1500x001","38.1501","38.3401","38.3402","38.3403","38.3501","38.4400x001","38.4400x002","38.4400x003","38.4401","38.4500x001","38.4500x003","38.4500x004","38.4500x007","38.4500x009","38.4500x010","38.4500x011","38.4500x013","38.4500x014","38.4500x015","38.4500x016","38.4500x018","38.4500x019","38.4500x021","38.4501","38.4502","38.4503","38.4504","38.4505","38.4506","38.4507","38.4510","38.4511","38.4700x001","38.4702","38.6400x001","38.6401","38.6402","38.6500x003","38.6500x004","38.6700x005","38.6701","38.7x01","38.7x02","38.8401","38.8500x013","38.8501","38.8502","39.0x01","39.0x04","39.0x05","39.1x00x006","39.1x00x008","39.1x00x009","39.1x00x010","39.1x00x011","39.1x01","39.1x03","39.1x04","39.1x05","39.1x06","39.1x08","39.1x09","39.2200x001","39.2200x008","39.2200x009","39.2200x010","39.2200x012","39.2200x015","39.2200x016","39.2200x021","39.2201","39.2203","39.2204","39.2207","39.2212","39.2300x003","39.2300x005","39.2300x016","39.2300x017","39.2300x018","39.2300x019","39.2300x020","39.2300x021","39.2300x022","39.2300x024","39.2301","39.2302","39.2303","39.2304","39.2305","39.2306","39.2308","39.2309","39.2400x001","39.2400x002","39.2401","39.2500x001","39.2500x002","39.2500x003","39.2500x004","39.2500x007","39.2500x008","39.2500x016","39.2500x017","39.2500x018","39.2500x019","39.2502","39.2503","39.2505","39.2507","39.2509","39.2510","39.2600x001","39.2600x008","39.2606","39.3100x012","39.3100x013","39.3107","39.3203","39.3205","39.4900x010","39.5200x005","39.5200x006","39.5200x010","39.5200x013","39.5203","39.5400x001","39.5600x001","39.5700x003","39.5700x004","39.5900x002","39.5900x009","39.5900x016","39.5900x018","39.5900x030","39.5900x032","39.7900x517","39.9100x003","54.9402"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合FE2入组条件，匹配规则：主手术匹配");
                    
                if (MDCF_DRG.FE29_group(record))
                {
                    return "FE29";
                }

                return "FE2";
            }else{
                return "";
            }
        }
    }
}