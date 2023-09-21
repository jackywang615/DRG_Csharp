namespace drg_group.lanzhou_2023{
    public class DU1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"H61.100x002","H61.100x005","H61.100x006","H61.100x009","H61.101","H61.102","H61.300","H61.800x005","H61.803","H61.902","J34.200","J34.800x009","J34.802","J34.805","J34.811","J38.701","J38.702","J39.213","K08.102","K13.002","K13.008","K13.700","K13.706","K13.709","K13.714","M95.001","M95.002","M95.003","M95.005","M95.006","M95.007","M95.100","M95.201","M95.202","M95.203","M95.204","M95.205","M95.206","M95.207","M95.208","M95.209","M95.210","S00.000x053","S00.001","S00.002","S00.003","S00.004","S00.300","S00.300x051","S00.302","S00.400","S00.400x052","S00.401","S00.402","S00.403","S00.404","S00.500","S00.500x051","S00.500x052","S00.501","S00.700","S00.800x053","S00.800x054","S00.800x055","S00.800x056","S00.801","S00.802","S00.803","S00.804","S00.900","S01.000","S01.001","S01.200x011","S01.200x021","S01.200x031","S01.200x091","S01.200x092","S01.300x002","S01.300x011","S01.300x012","S01.300x031","S01.300x051","S01.300x061","S01.300x071","S01.300x081","S01.301","S01.302","S01.400x011","S01.400x021","S01.400x031","S01.401","S01.500x001","S01.500x021","S01.500x022","S01.500x042","S01.500x051","S01.500x052","S01.501","S01.502","S01.503","S01.504","S01.505","S01.506","S01.700","S01.802","S01.803","S01.804","S01.900","S02.200","S02.201","S02.211","S02.400x001","S02.400x003","S02.400x005","S02.401","S02.411","S02.412","S02.500","S02.500x002","S02.501","S02.600","S02.600x011","S02.600x021","S02.600x031","S02.600x041","S02.600x051","S02.600x061","S02.600x081","S02.600x091","S02.611","S02.612","S02.700x004","S02.711","S02.800x003","S02.802","S02.803","S02.810","S02.812","S02.813","S02.901","S02.912","S03.000","S03.000x001","S03.100","S03.200","S03.301","S03.400","S03.400x001","S03.400x002","S03.501","S08.000","S08.100","S08.800","S08.801","S09.101","S09.200","S09.800x002","S09.800x003","S09.801","S09.900","S09.900x006","S09.901","S09.902","S09.903","S09.904","S09.905","S09.906","S09.907","S10.000x003","S10.001","S10.002","S10.003","S10.004","S10.101","S10.102","S10.700","S10.801","S10.900","S10.901","S10.902","S11.001","S11.002","S11.003","S11.004","S11.100x001","S11.201","S11.700","S11.800x081","S11.800x082","S11.900","S12.803","S12.813","S12.814","S12.815","S13.400","S13.400x003","S13.400x005","S13.401","S13.402","S13.403","S13.500","S13.500x003","S13.500x004","S13.500x005","S13.500x006","S13.500x007","S13.500x008","S13.500x009","S13.500x010","S13.500x011","S13.501","S13.502","S13.601","S15.001","S15.002","S15.003","S15.004","S15.005","S15.100","S15.200","S15.300","S15.301","S15.800x002","S15.800x003","S15.801","S15.900x001","S17.000x001","S17.000x002","S17.001","S17.800","S17.801","S17.900","S19.800x002","S19.800x004","S19.801","S19.802","S19.900","T17.000","T17.001","T17.002","T18.001","T81.800x008","T81.800x013"};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && adrg_zd.Contains(record.zdList[0])){
                Base.groupMessages.putMessage(record.Index,"符合DU1入组条件，匹配规则：主诊断匹配");
                    
                if (MDCD_DRG.DU15_group(record))
                {
                    return "DU15";
                }
    
                if (MDCD_DRG.DU13_group(record))
                {
                    return "DU13";
                }
    
                if (MDCD_DRG.DU11_group(record))
                {
                    return "DU11";
                }

                return "DU1";
            }else{
                return "";
            }
        }
    }
}