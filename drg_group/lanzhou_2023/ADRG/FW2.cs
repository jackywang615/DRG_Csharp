namespace drg_group.lanzhou_2023{
    public class FW2
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"C79.800x830","C79.800x830","I28.800x003","I28.802","I28.804","I77.000x008","I80.001","I80.002","I80.100x003","I80.101","I80.102","I80.103","I80.104","I80.201","I80.202","I80.203","I80.204","I80.206","I80.207","I80.208","I80.209","I80.300x005","I80.300x006","I80.301","I80.302","I80.303","I80.800","I80.800x002","I80.800x006","I80.800x007","I80.802","I80.803","I80.804","I80.901","I80.902","I82.100x001","I82.200x001","I82.201","I82.202","I82.203","I82.204","I82.300x001","I82.301","I82.302","I82.800x002","I82.800x003","I82.800x004","I82.800x005","I82.800x009","I82.801","I82.802","I82.803","I82.804","I82.805","I82.806","I82.900x001","I82.900x002","I82.900x003","I82.900x004","I83.000","I83.001","I83.100x001","I83.101","I83.102","I83.200x001","I83.900x004","I83.901","I83.902","I83.903","I83.904","I83.905","I86.800x005","I86.800x011","I86.800x015","I86.800x017","I86.801","I86.802","I86.804","I86.805","I86.806","I86.807","I86.811","I86.813","I86.814","I86.815","I86.816","I87.000","I87.001","I87.100x003","I87.100x007","I87.100x008","I87.100x009","I87.101","I87.102","I87.103","I87.104","I87.106","I87.110","I87.111","I87.112","I87.113","I87.114","I87.115","I87.116","I87.117","I87.118","I87.119","I87.200x001","I87.201","I87.202","I87.801","I87.802","I87.805","I87.900","I89.007","I89.100x003","I97.802","Q27.400","Q27.800x008","Q27.800x031","Q27.800x039","Q27.800x042","Q27.817","Q27.818","Q27.900","Q28.900x001","Q82.800x015","Q82.800x016","Q82.811","Q82.812","Q87.203","R02.x00","S25.200x001","S25.201","S25.300x001","S25.301","S25.800x003","S25.801","S35.100","S35.100x003","S35.101","S35.102","S35.300x001","S35.300x002","S35.300x003","S35.300x004","S35.300x005","S35.301","S35.302","S35.400x002","S35.401","S35.500x004","S35.500x006","S35.500x008","S35.502","S35.503","S35.700x003","S35.800x002","S35.801","S45.200x002","S45.201","S45.300x001","S45.300x002","S45.301","S55.200x001","S75.100x001","S75.100x002","S75.100x003","S75.200","S75.200x001","S85.300x001","S85.400x001","S85.500","S95.200","T80.100","T81.702","T82.501","T82.801","T82.808"};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && adrg_zd.Contains(record.zdList[0])){
                Base.groupMessages.putMessage(record.Index,"符合FW2入组条件，匹配规则：主诊断匹配");
                    
                if (MDCF_DRG.FW21_group(record))
                {
                    return "FW21";
                }
    
                if (MDCF_DRG.FW23_group(record))
                {
                    return "FW23";
                }
    
                if (MDCF_DRG.FW25_group(record))
                {
                    return "FW25";
                }

                return "FW2";
            }else{
                return "";
            }
        }
    }
}