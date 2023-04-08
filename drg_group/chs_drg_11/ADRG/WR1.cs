namespace drg_group.chs_drg_11{
    public class WR1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"T20.300","T20.300x002","T20.300x003","T20.300x004","T20.300x005","T20.300x006","T20.300x007","T20.300x008","T20.300x009","T20.300x010","T20.300x011","T20.300x012","T20.700","T20.700x002","T20.700x003","T20.700x004","T20.700x005","T20.700x006","T20.700x007","T20.700x008","T20.700x009","T20.700x010","T20.700x011","T20.700x012","T21.300","T21.300x011","T21.300x021","T21.300x031","T21.300x032","T21.300x033","T21.300x041","T21.300x042","T21.300x043","T21.300x051","T21.300x052","T21.300x053","T21.300x054","T21.300x055","T21.300x056","T21.300x057","T21.300x091","T21.700","T21.700x011","T21.700x021","T21.700x031","T21.700x032","T21.700x033","T21.700x041","T21.700x042","T21.700x043","T21.700x051","T21.700x052","T21.700x053","T21.700x054","T21.700x055","T21.700x056","T21.700x057","T21.700x091","T22.300x001","T22.300x002","T22.300x003","T22.300x004","T22.300x005","T22.300x006","T22.700x001","T22.700x002","T22.700x003","T22.700x004","T22.700x005","T22.700x006","T23.300","T23.300x002","T23.300x003","T23.300x004","T23.300x005","T23.300x006","T23.300x007","T23.700","T23.700x002","T23.700x003","T23.700x004","T23.700x005","T23.700x006","T23.700x007","T24.300x001","T24.300x002","T24.300x003","T24.300x004","T24.700x001","T24.700x002","T24.700x003","T24.700x004","T25.300","T25.300x002","T25.300x003","T25.700","T25.700x002","T25.700x003","T29.300x001","T29.700x001","T30.300","T30.700","T31.300","T31.400","T31.500","T31.600","T31.700","T31.800","T31.900","T32.300","T32.400","T32.500","T32.600","T32.700","T32.800","T32.900","T34.000","T34.100","T34.200","T34.300x001","T34.300x002","T34.300x003","T34.400","T34.500x002","T34.500x003","T34.600x002","T34.600x003","T34.700x002","T34.700x003","T34.800x002","T34.800x003","T34.900x002","T34.900x003","T35.100x001","T35.600x001","T35.700x008","T35.700x009"};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && adrg_zd.Contains(record.zdList[0])){
                Base.groupMessages.putMessage(record.Index,"符合WR1入组条件，匹配规则：主诊断匹配");
                    
                if (MDCW_DRG.WR19_group(record))
                {
                    return "WR19";
                }

                return "WR1";
            }else{
                return "";
            }
        }
    }
}