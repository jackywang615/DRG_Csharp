namespace drg_group.chs_drg_11{
    public class WJ1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && Base.SS_VALID.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合WJ1入组条件，匹配规则：存在手术");
                    
                if (MDCW_DRG.WJ19_group(record))
                {
                    return "WJ19";
                }

                return "WJ1";
            }else{
                return "";
            }
        }
    }
}