namespace drg_group.changzhou_2022{
    public class QD1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"34.0200x001","34.0200x003","34.0401","34.2000","34.2100x001","34.2200","34.2501","34.2502","34.2600","38.7x01","38.7x02","38.7x03","38.7x04","38.8606","39.7900x809","39.7904","39.9000x010","40.0x00x001","40.0x00x002","40.0x01","40.1100x003","40.1100x004","40.2200","40.2400","40.2900x002","40.2900x008","40.2900x019","40.2900x020","40.2902","40.2904","40.2906","40.2908","40.2910","40.3x00x001","40.3x00x002","40.4100","40.4200","40.5000","40.5100","40.5101","40.5301","40.5400x001","40.5400x002","40.5400x003","40.5900x010","40.5901","40.5905","40.5906","40.5907","40.5908","40.5909","40.5910","40.5911","40.5912","40.5914","40.6100","40.6200","40.6300","40.6301","40.6400","40.6900x002","40.6900x003","40.6900x004","40.6901","40.9x00x003","40.9x00x004","40.9x00x006","40.9x00x007","40.9x00x008","40.9x00x009","40.9x00x010","40.9x00x011","40.9x00x012","40.9x00x013","40.9x00x014","40.9x00x015","40.9x00x016","40.9x00x017","40.9x01","40.9x02","40.9x03","40.9x04","40.9x05","40.9x06","40.9x07","40.9x08","40.9x09","41.1x00","41.3300","41.4200x003","41.9100x001","41.9200","41.9201","41.9202","41.9203","51.2300","54.1100","54.1101","54.1900x001","54.1900x005","54.1900x010","54.1900x011","54.1900x020","54.1901","54.1902","54.1904","54.1907","54.2100","54.2300x003","54.2300x004","54.2300x005","54.2300x006","54.2301","54.2302","54.2303","54.2400x001","54.2400x002","54.2400x003","54.2400x006","86.2200x011","86.2800x012"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合QD1入组条件，匹配规则：主手术匹配");
                    
                if (MDCQ_DRG.QD13_group(record))
                {
                    return "QD13";
                }
    
                if (MDCQ_DRG.QD15_group(record))
                {
                    return "QD15";
                }

                return "QD1";
            }else{
                return "";
            }
        }
    }
}