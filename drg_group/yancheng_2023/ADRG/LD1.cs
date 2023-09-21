namespace drg_group.yancheng_2023{
    public class LD1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"03.9400x001","04.9200x003","04.9203","04.9301","56.4103","56.5101","56.5102","56.7101","56.7103","56.7200","56.7401","56.8909","57.0x00x002","57.0x00x003","57.0x00x005","57.0x00x006","57.0x00x007","57.0x00x008","57.0x00x009","57.0x00x010","57.0x00x011","57.0x00x012","57.0x00x013","57.0x02","57.0x03","57.0x04","57.0x05","57.0x06","57.0x07","57.0x08","57.1200","57.1700x002","57.1901","57.1902","57.1903","57.1904","57.1905","57.2100","57.2200","57.3400x002","57.4100x002","57.4900x001","57.4901","57.4902","57.4903","57.4904","57.5100","57.5100x001","57.5100x003","57.5101","57.5102","57.5900x001","57.5900x002","57.5901","57.5902","57.5903","57.5904","57.5905","57.5906","57.6x00","57.6x01","57.6x02","57.6x03","57.6x04","57.6x05","57.6x06","57.7100","57.7101","57.7102","57.7103","57.7900x001","57.7901","57.8100","57.8200","57.8301","57.8302","57.8303","57.8304","57.8305","57.8400x004","57.8400x005","57.8401","57.8402","57.8403","57.8404","57.8405","57.8500x002","57.8501","57.8502","57.8600","57.8700x005","57.8700x006","57.8700x007","57.8700x008","57.8700x009","57.8701","57.8702","57.8703","57.8704","57.8705","57.8706","57.8707","57.8801","57.8900x001","57.8900x003","57.8900x004","57.8901","57.8902","57.8903","57.8904","57.8905","57.9101","57.9102","57.9103","57.9201","57.9300x001","57.9300x002","57.9301","57.9600","57.9700","57.9800","57.9900x001","57.9900x002","59.1100x001","59.1200","59.1901","59.3x00","59.4x01","59.4x02","59.4x03","59.4x04","59.4x05","59.7101","59.7200","70.5001","70.5002","70.5100","70.5101","70.5102","70.5300x001","70.5300x002","70.5400x001","70.5400x002","70.7703","75.6101"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合LD1入组条件，匹配规则：主手术匹配");
                    
                if (MDCL_DRG.LD19_group(record))
                {
                    return "LD19";
                }

                return "LD1";
            }else{
                return "";
            }
        }
    }
}