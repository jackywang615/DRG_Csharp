namespace drg_group.chs_drg_11{
    public class IC1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"00.7000x001","00.7100x001","00.7200x001","00.7201","00.7300x001","00.7300x002","00.7300x003","00.7301","00.8000x001","00.8100x001","00.8200x001","00.8201","00.8300x001","00.8400x001","81.9700x002","81.9701","81.9702"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合IC1入组条件，匹配规则：主手术匹配");
                    
                if (MDCI_DRG.IC19_group(record))
                {
                    return "IC19";
                }

                return "IC1";
            }else{
                return "";
            }
        }
    }
}