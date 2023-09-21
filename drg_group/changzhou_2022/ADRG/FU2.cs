namespace drg_group.changzhou_2022{
    public class FU2
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"G90.800x004","I25.104","I44.000","I44.302","I44.303","I44.304","I44.400","I44.500","I44.601","I44.602","I44.700","I45.000","I45.101","I45.102","I45.103","I45.200","I45.400x001","I45.401","I45.800x002","I45.800x004","I45.801","I45.804","I45.900x002","I45.900x003","I47.000","I47.100","I47.100x001","I47.100x004","I47.100x005","I47.100x013","I47.100x014","I47.101","I47.102","I47.103","I47.104","I47.105","I47.106","I47.107","I47.108","I47.109","I47.110","I47.111","I47.900","I48.000","I48.100","I48.100x002","I48.100x003","I48.200","I48.300","I48.301","I48.400","I48.401","I48.900x004","I48.900x015","I49.100x001","I49.101","I49.200x001","I49.300x002","I49.301","I49.303","I49.400x001","I49.401","I49.402","I49.403","I49.404","I49.500","I49.501","I49.800x001","I49.800x002","I49.800x003","I49.800x005","I49.800x006","I49.800x007","I49.800x010","I49.800x015","I49.801","I49.802","I49.804","I49.900","R00.000","R00.001","R00.100","R00.100x001","R00.200","R00.800","R00.800x001","R00.800x003","R00.801","R94.300x011","R94.300x012","R94.308"};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && adrg_zd.Contains(record.zdList[0])){
                Base.groupMessages.putMessage(record.Index,"符合FU2入组条件，匹配规则：主诊断匹配");
                    
                if (MDCF_DRG.FU21_group(record))
                {
                    return "FU21";
                }
    
                if (MDCF_DRG.FU23_group(record))
                {
                    return "FU23";
                }
    
                if (MDCF_DRG.FU25_group(record))
                {
                    return "FU25";
                }
    
                if (MDCF_DRG.FU27_group(record))
                {
                    return "FU27";
                }

                return "FU2";
            }else{
                return "";
            }
        }
    }
}