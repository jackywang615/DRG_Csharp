namespace drg_group.chs_drg_11{
    public class RW1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"Z08.000","Z08.100","Z08.200","Z08.700","Z08.800x001","Z08.800x002","Z08.800x003","Z08.800x004","Z08.900","Z09.100","Z09.200","Z54.001"};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && adrg_zd.Contains(record.zdList[0])){
                Base.groupMessages.putMessage(record.Index,"符合RW1入组条件，匹配规则：主诊断匹配");
                    
                if (MDCR_DRG.RW19_group(record))
                {
                    return "RW19";
                }

                return "RW1";
            }else{
                return "";
            }
        }
    }
}