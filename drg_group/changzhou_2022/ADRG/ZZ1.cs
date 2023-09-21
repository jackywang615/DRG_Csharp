namespace drg_group.changzhou_2022{
    public class ZZ1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && !Base.intersect(record.ssList,Base.SS_VALID)){
                Base.groupMessages.putMessage(record.Index,"符合ZZ1入组条件，匹配规则：无手术");
                    
                if (MDCZ_DRG.ZZ11_group(record))
                {
                    return "ZZ11";
                }
    
                if (MDCZ_DRG.ZZ13_group(record))
                {
                    return "ZZ13";
                }
    
                if (MDCZ_DRG.ZZ15_group(record))
                {
                    return "ZZ15";
                }
    
                if (MDCZ_DRG.ZZ17_group(record))
                {
                    return "ZZ17";
                }

                return "ZZ1";
            }else{
                return "";
            }
        }
    }
}