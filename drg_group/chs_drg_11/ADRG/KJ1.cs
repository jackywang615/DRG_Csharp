namespace drg_group.chs_drg_11{
    public class KJ1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"18.9x00x007","40.0x00x002","40.2900x002","40.3x00x001","40.3x00x002","40.3x00x003","44.9201","44.9701","45.6201","45.6202","45.6203","45.6204","45.6205","45.6206","45.6207","45.6208","45.7500","45.7500x001","45.9300x012","45.9300x013","45.9300x014","45.9300x015","45.9301","45.9302","45.9303","45.9304","45.9305","45.9306","45.9307","45.9310","45.9400x004","45.9400x009","45.9400x012","45.9400x016","45.9401","45.9402","45.9403","45.9404","45.9405","45.9406","45.9407","45.9408","45.9502","45.9503","52.2201","52.2202","52.5101","52.5102","52.5103","52.5104","52.5201","52.5202","52.5203","52.5204","52.5205","52.5206","52.5300","52.5301","52.5901","52.5902","52.5903","52.5904","52.5905","52.5906","54.0x00x002","54.0x00x004","54.0x00x006","54.0x00x010","54.0x00x013","54.0x00x018","54.0x00x021","54.0x00x022","54.0x00x023","54.0x00x024","54.0x00x025","54.0x01","54.0x02","54.0x03","54.1100","54.1101","54.1201","54.1202","54.1900x001","54.1900x005","54.1900x010","54.1900x011","54.1901","54.1902","54.1903","54.1904","54.1907","54.1909","54.3x00x004","54.3x00x010","54.3x00x011","54.3x00x027","54.3x01","54.3x02","54.3x03","54.3x04","54.3x05","54.3x06","54.3x07","54.4x00x005","54.4x00x006","54.4x00x007","54.4x00x012","54.4x00x021","54.4x00x035","54.4x00x039","54.4x00x042","54.4x00x048","54.4x01","54.4x02","54.4x03","54.4x04","54.4x05","54.4x06","54.4x07","54.4x08","54.4x09","54.4x10","54.4x11","54.4x12","54.4x13","54.4x14","54.4x15","54.4x16","54.5100","54.5100x005","54.5100x009","54.5101","54.5102","54.5103","54.5900x007","54.5901","54.5902","54.5903","54.5904","54.5905","54.5906","54.6101","54.6301","54.6400","54.6401","54.7100","54.7200x001","54.7300x001","54.7400x001","54.7400x002","54.7400x003","54.7400x004","54.7400x005","54.7400x006","54.7404","54.7500x002","54.7501","86.2200x011","86.2800x012","86.6301","86.6302","86.6303","86.6304","86.6701","86.6702","86.6903","86.6904","86.6905","86.6906","86.7100x009","86.7101","86.7102","86.7103","86.7104","86.7105","86.7200x001","86.7400x026","86.7400x031","86.7400x032","86.7400x033","86.7400x034","86.7400x035","86.7400x036","86.7400x037","86.7400x038","86.7400x039","86.7400x040","86.7400x041","86.7400x042","86.7401","86.7402","86.7403","86.7404","86.7405","86.7500x001","86.7500x010","86.7501","86.7503","86.8300x031","86.8300x032","86.8301","86.8302","86.8303","86.8304","86.8305","86.8306","86.8900x002","86.8900x011","86.9000x001","86.9301","86.9302","86.9303","86.9305","86.9306"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合KJ1入组条件，匹配规则：主手术匹配");
                    
                if (MDCK_DRG.KJ11_group(record))
                {
                    return "KJ11";
                }
    
                if (MDCK_DRG.KJ15_group(record))
                {
                    return "KJ15";
                }

                return "KJ1";
            }else{
                return "";
            }
        }
    }
}