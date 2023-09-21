namespace drg_group.wlmq_2022{
    public class BT2
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"A01.002+G01*","A02.203+G01*","A06.600+G07*","A17.000+G01*","A17.000x001+G05.0*","A17.000x005+G01*","A17.000x006+G01*","A17.001+G01*","A17.100+G07*","A17.100x001+G07*","A17.800x007+G05.0*","A17.801+G07*","A17.802+G07*","A17.803+G05.0*","A17.804+G05.0*","A17.805+G07*","A17.806+G07*","A17.807+G94.0*","A17.900+G99.8*","A17.900x001+G99.8*","A18.822+I68.1*","A22.801+G01*","A23.900x005+G05.0*","A32.101+G01*","A32.102+G05.0*","A32.801+I68.1*","A36.803+G63.0*","A37.900x005","A39.000+G01*","A39.000x004+G01*","A39.000x005+G01*","A39.000x006+G01*","A39.000x007+G01*","A39.000x008+G01*","A39.001+G01*","A39.002+G01*","A39.003+G01*","A39.100+E35.1*","A39.200","A39.300","A39.400","A39.802+G05.0*","A39.803+G05.0*","A39.900","A42.800x003+G01*","A50.400x002+G01*","A50.400x003+G05.0*","A50.400x004+G63.0*","A50.402+G01*","A51.401+G01*","A52.001+I68.1*","A52.100x005+G22*","A52.100x006+G59.8*","A52.100x007+G05.0*","A52.100x008+G63.0*","A52.100x009+G01*","A52.100x010+G05.0*","A52.105+G01*","A52.106+H48.0*","A54.801+G07*","A54.803+G01*","A69.200x002+G63.0*","A79.900x003+G05.2*","A81.200","A81.800","A81.800x001","A81.801","A81.900","A88.800","A89.x00","B02.200x004+G53.0*","B02.200x008+G63.0*","B02.201+G53.0*","B02.202+G53.0*","B02.203+G53.0*","B02.204+G53.1*","B02.206+G53.0*","B02.207+G53.0*","B26.800x003+G63.0*","B37.500+G02.1*","B38.400+G02.1*","B43.101+G07*","B45.100x002+G02.1*","B45.101+G02.1*","B45.102+G05.2*","B49.x01+G02.1*","B50.000x001+G94.8*","B57.400x001+G02.8*","B57.400x002+G05.2*","B58.200+G05.2*","B58.200x002+G05.2*","B58.201+G05.2*","B60.200x001+G05.2*","B60.200x002+G05.2*","B60.201+G05.2*","B65.901+G07*","B69.000x002+G94.8*","B69.001+G94.8*","B83.202+G05.2*","B99.x00x003+G94.0*","C79.300x030","G00.000","G00.000x001","G00.100","G00.200","G00.300","G00.800","G00.800x002","G00.800x003","G00.800x005","G00.801","G00.802","G00.803","G00.900","G00.900x003","G00.901","G00.902","G00.903","G00.904","G03.000","G03.001","G03.002","G03.100","G03.200","G03.800","G03.800x003","G03.800x004","G03.800x005","G03.801","G03.802","G03.900","G03.900x008","G03.901","G03.902","G03.903","G03.904","G03.906","G03.907","G04.200","G04.201","G04.800x003","G04.800x007","G04.800x008","G04.800x009","G04.800x010","G04.802","G04.803","G04.804","G04.805","G04.807","G04.808","G04.900x001","G04.900x005","G04.900x010","G04.900x011","G04.900x019","G04.900x021","G04.900x024","G04.900x025","G04.900x027","G04.900x031","G04.903","G04.904","G04.905","G04.906","G04.907","G04.908","G04.911","G04.912","G04.913","G04.914","G04.916","G04.917","G04.918","G04.919","G04.920","G04.921","G04.922","G06.000x001","G06.000x002","G06.000x003","G06.000x004","G06.000x005","G06.000x007","G06.000x008","G06.000x009","G06.000x011","G06.000x012","G06.000x013","G06.000x014","G06.000x015","G06.000x018","G06.000x020","G06.000x021","G06.000x022","G06.001","G06.002","G06.003","G06.004","G06.005","G06.006","G06.008","G06.009","G06.100x002","G06.100x003","G06.100x004","G06.100x006","G06.100x008","G06.100x009","G06.101","G06.102","G06.103","G06.200","G06.200x003","G06.201","G06.202","G06.203","G08.x00","G08.x00x001","G08.x00x002","G08.x00x003","G08.x00x004","G08.x00x005","G08.x00x006","G08.x00x007","G08.x00x008","G08.x00x009","G08.x00x010","G08.x00x011","G08.x00x013","G08.x01","G08.x02","G09.x00x002","G09.x00x003","R29.100"};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && adrg_zd.Contains(record.zdList[0])){
                Base.groupMessages.putMessage(record.Index,"符合BT2入组条件，匹配规则：主诊断匹配");
                    
                if (MDCB_DRG.BT23_group(record))
                {
                    return "BT23";
                }
    
                if (MDCB_DRG.BT25_group(record))
                {
                    return "BT25";
                }

                return "BT2";
            }else{
                return "";
            }
        }
    }
}