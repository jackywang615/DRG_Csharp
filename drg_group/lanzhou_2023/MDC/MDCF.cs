namespace drg_group.lanzhou_2023
{
    public class MDCF
    {
        public static String group(MedicalRecord record){
            String[] mdc_zd={"A01.000x016+I41.0*","A18.808+I32.0*","A18.809+I32.0*","A18.818+I79.8*","A18.820+I39.8*","A18.821+I41.0*","A32.802+I39.8*","A36.802+I41.0*","A38.x00x002+I41.0*","A39.500","A39.501+I32.0*","A39.502+I39.8*","A39.503+I41.0*","A39.504+I52.0*","A52.000+I98.0*","A52.000x001+I52.0*","A52.000x006+I39.1*","A52.000x007+I39.1*","A52.000x011+I39.0*","A52.002+I79.1*","A52.003+I79.0*","A52.004+I39.1*","A52.005+I52.0*","A52.006+I39.8*","A52.007+I41.0*","A52.008+I32.0*","A52.009+I39.3*","A54.802+I39.8*","A54.804+I41.0*","A54.805+I32.0*","B01.800x001+I41.1*","B25.803+I41.1*","B26.803+I41.1*","B33.200","B33.200x001+I32.1*","B33.200x002+I39.8*","B33.200x004+I41.1*","B33.201+I41.1*","B37.600+I39.8*","B49.x15","B57.001+I98.1*","B57.002+I41.2*","B57.201+I98.1*","B57.202+I41.2*","B57.202+I41.2*","B58.800x001+I41.2*","C38.000","C38.000x004","C38.001","C38.002","C45.200","C49.300x006","C49.402","C49.900x001","C75.400","C75.500x001","C75.501","C79.800x807","C79.800x819","C79.800x830","C79.800x830","C79.800x830","C79.800x863","C79.808","D15.100","D15.101","D15.102","D15.103","D15.104","D15.105","D15.106","D18.000x001","D18.000x003","D18.000x004","D18.000x005","D18.000x822","D18.000x835","D18.000x836","D18.000x837","D18.000x840","D18.000x841","D18.010","D20.000x002","D21.300x005","D21.400","D21.400x004","D35.600x001","D44.601","D44.700","D44.700x002","D44.700x003","D44.700x004","D44.701","D44.702","D44.703","D48.100x008","D48.100x024","D48.711","D48.712","D86.800x005+I41.8*","E03.900x004+I43.8*","E05.900x004+I43.8*","E05.900x004+I43.8*","E05.903+I43.8*","E10.400x311+G99.0*","E10.502+I79.2*","E10.700x011","E10.700x022","E10.700x023","E11.500x021+I79.2*","E11.501+I79.2*","E11.502+I79.2*","E11.700x022","E11.700x023","E13.500x241+I79.2*","E13.500x541+I79.2*","E14.500x031+I43.8*","E14.500x032+I43.8*","E14.700x022","E14.700x023","E16.800x101","E16.800x102","E63.901+I43.2*","E74.006+K77.8*","E74.008+I43.1*","E76.300x002+I52.8*","E83.103","E85.408","E85.416+I43.1*","E88.907+I43.1*","I01.000","I01.100","I01.200","I01.800x001","I01.900","I02.000x001","I02.900x001","I02.900x003","I05.000","I05.000x001","I05.100","I05.200","I05.200x001","I05.800","I05.900","I05.900x001","I06.000","I06.100","I06.200","I06.800x001","I06.900","I07.000","I07.000x001","I07.100","I07.100x001","I07.200","I07.200x001","I07.800","I07.900","I07.900x001","I08.000","I08.000x001","I08.000x002","I08.000x003","I08.000x004","I08.000x005","I08.000x006","I08.000x007","I08.000x008","I08.000x009","I08.000x010","I08.001","I08.002","I08.003","I08.004","I08.005","I08.006","I08.007","I08.008","I08.009","I08.100","I08.100x001","I08.100x002","I08.100x003","I08.100x004","I08.100x005","I08.101","I08.102","I08.103","I08.104","I08.200","I08.200x001","I08.200x002","I08.201","I08.300","I08.300x001","I08.300x002","I08.300x003","I08.300x004","I08.300x005","I08.300x006","I08.300x007","I08.301","I08.302","I08.303","I08.304","I08.305","I08.306","I08.800","I08.800x002","I08.800x003","I08.801","I08.900","I08.901","I09.000","I09.100x001","I09.100x002","I09.200","I09.200x001","I09.200x003","I09.200x004","I09.801","I09.802","I09.900","I09.900x002","I10.x00x002","I10.x00x007","I10.x00x008","I10.x00x009","I10.x00x015","I10.x00x016","I10.x00x017","I10.x01","I10.x02","I10.x03","I10.x04","I10.x05","I10.x06","I10.x08","I10.x09","I10.x10","I10.x12","I10.x13","I10.x14","I11.001","I11.002","I11.901","I12.902","I13.000x001","I13.200x001","I13.900x001","I13.900x001","I15.000","I15.100x001","I15.101","I15.102","I15.103","I15.200x001","I15.200x002","I15.200x003","I15.200x004","I15.200x005","I15.800x001","I15.800x002","I15.800x003","I15.800x004","I15.800x006","I15.900","I20.000","I20.000x004","I20.000x005","I20.001","I20.002","I20.003","I20.004","I20.005","I20.006","I20.101","I20.102","I20.800x006","I20.800x007","I20.801","I20.802","I20.803","I20.806","I20.807","I20.808","I20.808","I20.900","I21.000x005","I21.001","I21.002","I21.003","I21.004","I21.103","I21.104","I21.105","I21.106","I21.200x003","I21.200x009","I21.200x010","I21.200x011","I21.200x014","I21.200x015","I21.200x016","I21.200x017","I21.200x018","I21.200x019","I21.200x020","I21.200x021","I21.200x022","I21.200x023","I21.200x024","I21.200x025","I21.200x026","I21.200x027","I21.200x029","I21.200x030","I21.204","I21.205","I21.206","I21.207","I21.208","I21.210","I21.211","I21.212","I21.213","I21.300x003","I21.300x004","I21.300x005","I21.300x008","I21.302","I21.303","I21.400x003","I21.401","I21.402","I21.900","I21.900x001","I21.901","I22.000x001","I22.000x002","I22.000x003","I22.000x004","I22.000x005","I22.100x001","I22.100x002","I22.100x003","I22.800x001","I22.800x002","I22.800x003","I22.800x004","I22.800x005","I22.800x006","I22.800x007","I22.800x008","I22.800x009","I22.800x010","I22.800x011","I22.800x012","I22.800x013","I22.800x014","I22.800x015","I22.800x016","I22.800x017","I22.800x018","I22.900x001","I23.000x001","I23.100x001","I23.200x001","I23.300x001","I23.400x001","I23.500x001","I23.601","I23.800x001","I24.000x003","I24.000x004","I24.000x005","I24.000x009","I24.000x010","I24.001","I24.002","I24.003","I24.100x001","I24.800x001","I24.800x004","I24.800x007","I24.801","I24.900x001","I24.901","I25.000x001","I25.100x003","I25.102","I25.103","I25.104","I25.300","I25.300x005","I25.300x006","I25.300x007","I25.300x008","I25.300x009","I25.300x010","I25.300x011","I25.300x012","I25.300x013","I25.301","I25.302","I25.400","I25.400x001","I25.400x005","I25.401","I25.402","I25.403","I25.500","I25.600x001","I25.800x002","I25.800x003","I25.800x004","I25.800x005","I25.800x006","I25.800x009","I25.800x010","I25.800x011","I25.800x012","I25.802","I25.900","I25.901","I25.902","I26.001","I27.000x007","I27.000x008","I27.000x009","I27.000x010","I27.001","I27.100","I27.200x002","I27.200x003","I27.200x004","I27.200x005","I27.200x006","I27.200x009","I27.200x012","I27.200x013","I27.200x015","I27.200x016","I27.200x017","I27.200x018","I27.200x019","I27.200x020","I27.200x021","I27.200x022","I27.201","I27.202","I27.801","I27.900","I27.900x002","I28.000x002","I28.000x003","I28.100","I28.800x003","I28.800x005","I28.800x007","I28.800x008","I28.801","I28.802","I28.803","I28.804","I28.900x001","I30.000","I30.100","I30.100x005","I30.100x006","I30.100x007","I30.100x008","I30.101","I30.102","I30.103","I30.801","I30.900","I30.900x001","I30.900x003","I31.000","I31.000x002","I31.001","I31.100","I31.100x001","I31.101","I31.200x001","I31.300","I31.300x005","I31.301","I31.302","I31.800x001","I31.800x003","I31.900x008","I31.900x009","I31.900x010","I31.901","I31.902","I31.903","I31.904","I33.000x001","I33.000x004","I33.000x006","I33.000x007","I33.000x008","I33.000x011","I33.000x012","I33.000x019","I33.000x020","I33.000x021","I33.000x022","I33.000x024","I33.001","I33.002","I33.003","I33.004","I33.005","I33.006","I33.007","I33.008","I33.009","I33.010","I33.011","I33.900","I34.000","I34.000x001","I34.001","I34.100","I34.101","I34.102","I34.200","I34.201","I34.202","I34.800x002","I34.800x003","I34.800x005","I34.800x006","I34.801","I34.802","I34.803","I34.900","I35.000","I35.000x002","I35.000x003","I35.100","I35.100x003","I35.101","I35.200","I35.200x001","I35.800x003","I35.801","I35.802","I35.803","I35.804","I35.805","I35.806","I35.807","I35.808","I35.900","I36.000","I36.100","I36.200","I36.800x002","I36.800x003","I36.800x004","I36.800x005","I36.801","I36.900","I37.000","I37.100","I37.200","I37.800","I37.900","I38.x00x002","I38.x00x005","I38.x00x006","I38.x00x007","I38.x01","I38.x02","I38.x03","I40.000x003","I40.000x004","I40.000x005","I40.000x006","I40.000x007","I40.001","I40.002","I40.100","I40.800x001","I40.800x002","I40.800x003","I40.900","I42.000x001","I42.001","I42.100","I42.100x002","I42.200x002","I42.201","I42.300","I42.301","I42.401","I42.500x001","I42.501","I42.600","I42.701","I42.800x001","I42.800x002","I42.800x004","I42.800x005","I42.800x006","I42.800x007","I42.801","I42.802","I42.803","I42.900","I42.901","I42.902","I42.904","I42.905","I44.000","I44.100","I44.101","I44.102","I44.200","I44.201","I44.300x003","I44.302","I44.303","I44.304","I44.400","I44.500","I44.601","I44.602","I44.700","I45.000","I45.101","I45.102","I45.103","I45.200","I45.300","I45.400x001","I45.401","I45.500x002","I45.500x004","I45.500x005","I45.501","I45.502","I45.600","I45.600x003","I45.600x004","I45.600x005","I45.600x007","I45.601","I45.602","I45.800x002","I45.800x004","I45.801","I45.804","I45.900x002","I45.900x003","I45.901","I46.000","I46.100x001","I46.901","I47.000","I47.100","I47.100x001","I47.100x004","I47.100x005","I47.100x013","I47.100x014","I47.101","I47.102","I47.103","I47.104","I47.105","I47.106","I47.107","I47.108","I47.109","I47.110","I47.111","I47.200","I47.200x001","I47.200x003","I47.200x005","I47.200x006","I47.200x007","I47.200x008","I47.200x009","I47.200x010","I47.200x011","I47.200x013","I47.200x014","I47.201","I47.202","I47.203","I47.204","I47.204","I47.900","I48.000","I48.100","I48.100x002","I48.100x003","I48.200","I48.300","I48.301","I48.400","I48.401","I48.900x003","I48.900x004","I48.900x015","I49.001","I49.002","I49.100x001","I49.101","I49.200x001","I49.300x002","I49.300x005","I49.301","I49.302","I49.303","I49.400x001","I49.401","I49.402","I49.403","I49.404","I49.500","I49.501","I49.800x001","I49.800x002","I49.800x003","I49.800x005","I49.800x006","I49.800x007","I49.800x010","I49.800x015","I49.800x016","I49.801","I49.802","I49.804","I49.805","I49.805","I49.900","I50.000","I50.000x005","I50.000x006","I50.001","I50.002","I50.100","I50.100x006","I50.101","I50.102","I50.103","I50.104","I50.105","I50.900","I50.900x001","I50.900x002","I50.900x007","I50.900x008","I50.900x009","I50.900x010","I50.900x014","I50.900x015","I50.900x016","I50.900x017","I50.900x018","I50.900x019","I50.906","I50.907","I50.908","I51.000x001","I51.001","I51.100x001","I51.200x001","I51.301","I51.302","I51.303","I51.304","I51.400","I51.400x005","I51.400x006","I51.401","I51.402","I51.403","I51.403","I51.404","I51.500x002","I51.500x006","I51.501","I51.502","I51.600x002","I51.600x003","I51.700","I51.700x003","I51.700x004","I51.700x006","I51.700x007","I51.700x009","I51.700x014","I51.700x015","I51.701","I51.702","I51.703","I51.704","I51.705","I51.706","I51.707","I51.708","I51.709","I51.800x004","I51.800x005","I51.800x006","I51.801","I51.802","I51.803","I51.900","I51.900x001","I51.900x002","I51.900x003","I51.901","I51.903","I67.200x003","I67.200x004","I67.203","I67.203","I67.203","I70.000x003","I70.000x005","I70.000x006","I70.000x007","I70.000x008","I70.000x009","I70.000x010","I70.000x011","I70.000x012","I70.000x013","I70.001","I70.002","I70.003","I70.004","I70.010","I70.011","I70.012","I70.013","I70.014","I70.100x002","I70.101","I70.102","I70.110","I70.111","I70.112","I70.200x002","I70.200x004","I70.200x005","I70.200x011","I70.200x021","I70.200x031","I70.200x061","I70.200x062","I70.200x063","I70.200x064","I70.200x065","I70.201","I70.203","I70.204","I70.206","I70.207","I70.208","I70.209","I70.210","I70.211","I70.213","I70.214","I70.217","I70.218","I70.219","I70.800x005","I70.800x006","I70.802","I70.804","I70.805","I70.810","I70.812","I70.900x002","I70.900x003","I70.900x004","I70.900x006","I70.900x007","I70.901","I70.902","I70.910","I70.911","I70.912","I71.000x002","I71.000x003","I71.000x004","I71.000x005","I71.000x006","I71.000x007","I71.000x008","I71.000x011","I71.000x012","I71.000x013","I71.000x014","I71.000x015","I71.000x016","I71.000x017","I71.000x021","I71.000x022","I71.000x023","I71.000x024","I71.000x025","I71.000x026","I71.000x027","I71.000x028","I71.000x029","I71.001","I71.002","I71.003","I71.004","I71.005","I71.006","I71.007","I71.100","I71.100x002","I71.100x003","I71.101","I71.200x006","I71.200x010","I71.200x011","I71.200x014","I71.201","I71.202","I71.203","I71.204","I71.205","I71.206","I71.300","I71.400x002","I71.401","I71.402","I71.500","I71.600x001","I71.600x004","I71.600x005","I71.800","I71.801","I71.900x002","I71.900x004","I71.901","I71.902","I71.903","I72.000","I72.000x011","I72.000x012","I72.000x013","I72.000x022","I72.000x023","I72.000x031","I72.000x032","I72.000x033","I72.000x321","I72.001","I72.002","I72.003","I72.004","I72.005","I72.006","I72.100","I72.100x003","I72.100x004","I72.100x005","I72.100x006","I72.100x007","I72.101","I72.103","I72.200","I72.200x001","I72.200x003","I72.201","I72.300","I72.300x003","I72.300x006","I72.300x012","I72.300x013","I72.300x021","I72.300x022","I72.300x023","I72.300x031","I72.300x032","I72.300x033","I72.301","I72.302","I72.303","I72.304","I72.305","I72.400","I72.400x010","I72.400x030","I72.400x110","I72.400x111","I72.400x112","I72.400x113","I72.400x121","I72.400x122","I72.400x123","I72.400x130","I72.400x131","I72.400x132","I72.400x133","I72.400x210","I72.400x212","I72.400x213","I72.400x220","I72.400x222","I72.400x223","I72.400x230","I72.400x232","I72.400x233","I72.400x310","I72.400x320","I72.400x330","I72.400x410","I72.400x420","I72.400x430","I72.400x520","I72.400x530","I72.401","I72.402","I72.403","I72.404","I72.405","I72.501","I72.600","I72.800x023","I72.800x042","I72.800x051","I72.800x053","I72.800x061","I72.800x093","I72.800x101","I72.800x102","I72.800x103","I72.800x111","I72.800x121","I72.800x151","I72.804","I72.805","I72.806","I72.808","I72.811","I72.812","I72.813","I72.814","I72.900","I72.900x002","I72.900x003","I72.900x004","I72.901","I73.001","I73.100","I73.800x001","I73.800x003","I73.800x006","I73.800x007","I73.800x008","I73.802","I73.803","I73.804","I73.805","I73.901","I73.902","I73.903","I74.000x003","I74.001","I74.002","I74.003","I74.004","I74.005","I74.006","I74.101","I74.102","I74.200x001","I74.200x004","I74.200x005","I74.200x006","I74.200x007","I74.201","I74.202","I74.300x030","I74.300x111","I74.300x112","I74.300x113","I74.300x121","I74.300x122","I74.300x123","I74.300x131","I74.300x132","I74.300x133","I74.300x210","I74.300x212","I74.300x213","I74.300x220","I74.300x222","I74.300x223","I74.300x230","I74.300x232","I74.300x233","I74.300x310","I74.300x320","I74.300x330","I74.300x410","I74.300x420","I74.300x430","I74.300x510","I74.300x520","I74.301","I74.302","I74.303","I74.304","I74.305","I74.307","I74.308","I74.310","I74.401","I74.402","I74.500x002","I74.500x007","I74.500x008","I74.500x009","I74.500x010","I74.500x011","I74.500x012","I74.500x013","I74.501","I74.502","I74.503","I74.504","I74.800x001","I74.800x004","I74.800x005","I74.800x006","I74.800x007","I74.800x008","I74.800x009","I74.800x010","I74.800x012","I74.801","I74.802","I74.805","I74.806","I74.807","I74.901","I74.902","I77.000x008","I77.000x011","I77.000x014","I77.000x015","I77.005","I77.006","I77.007","I77.008","I77.010","I77.011","I77.012","I77.013","I77.014","I77.100x004","I77.100x005","I77.100x012","I77.100x014","I77.100x015","I77.100x018","I77.100x027","I77.100x028","I77.100x029","I77.100x031","I77.100x032","I77.101","I77.102","I77.103","I77.104","I77.105","I77.106","I77.107","I77.108","I77.109","I77.110","I77.111","I77.112","I77.113","I77.114","I77.115","I77.117","I77.118","I77.118","I77.120","I77.121","I77.123","I77.125","I77.126","I77.127","I77.129","I77.131","I77.200","I77.201","I77.202","I77.203","I77.204","I77.300x002","I77.300x003","I77.301","I77.500","I77.600","I77.600x001","I77.600x004","I77.600x012","I77.600x013","I77.600x014","I77.600x015","I77.600x016","I77.601","I77.602","I77.603","I77.604","I77.605","I77.800x002","I77.800x006","I77.800x007","I77.800x008","I77.800x009","I77.800x010","I77.800x011","I77.800x012","I77.800x013","I77.800x014","I77.800x015","I77.800x016","I77.800x017","I77.800x018","I77.800x019","I77.800x020","I77.800x021","I77.800x022","I77.800x024","I77.801","I77.802","I77.803","I77.804","I77.805","I77.806","I77.807","I77.900","I78.000","I78.101","I78.102","I78.801","I78.803","I78.900","I80.001","I80.002","I80.100x003","I80.101","I80.102","I80.103","I80.104","I80.201","I80.202","I80.203","I80.204","I80.206","I80.207","I80.208","I80.209","I80.300x005","I80.300x006","I80.301","I80.302","I80.303","I80.800","I80.800x002","I80.800x006","I80.800x007","I80.802","I80.803","I80.804","I80.901","I80.902","I82.100x001","I82.200x001","I82.201","I82.202","I82.203","I82.204","I82.300x001","I82.301","I82.302","I82.800x002","I82.800x003","I82.800x004","I82.800x005","I82.800x009","I82.801","I82.802","I82.803","I82.804","I82.805","I82.806","I82.900x001","I82.900x002","I82.900x003","I82.900x004","I83.000","I83.001","I83.100x001","I83.101","I83.102","I83.200x001","I83.900x004","I83.901","I83.902","I83.903","I83.904","I83.905","I86.800x005","I86.800x011","I86.800x015","I86.800x017","I86.801","I86.802","I86.804","I86.805","I86.806","I86.807","I86.811","I86.813","I86.814","I86.815","I86.816","I87.000","I87.001","I87.100x003","I87.100x007","I87.100x008","I87.100x009","I87.101","I87.102","I87.103","I87.104","I87.106","I87.110","I87.111","I87.112","I87.113","I87.114","I87.115","I87.116","I87.117","I87.118","I87.119","I87.200x001","I87.201","I87.202","I87.801","I87.802","I87.805","I87.900","I89.001","I89.007","I89.100x003","I95.000","I95.100","I95.101","I95.200","I95.800x001","I95.900","I97.000","I97.000x002","I97.001","I97.100x004","I97.101","I97.102","I97.800x001","I97.800x002","I97.800x004","I97.800x005","I97.800x006","I97.800x008","I97.800x009","I97.800x010","I97.800x011","I97.800x013","I97.800x014","I97.800x015","I97.800x016","I97.800x017","I97.800x020","I97.801","I97.802","I97.803","I97.804","I97.900","I99.x01","J09.x03+I41.1*","J10.800x003+I41.1*","J10.802+I41.1*","J11.801+I41.1*","J94.000","M05.302+I43.8*","M05.304+I52.8*","M05.305+I32.8*","M05.306+I41.8*","M05.307+I39.8*","M10.004+I43.8*","M31.400","M31.600","M31.804","M32.104+I43.8*","M32.105+I32.8*","M32.109+I39.8*","M34.800x009+I52.8*","N18.505+I68.8*","N18.506+I32.8*","Q20.000","Q20.100","Q20.101","Q20.200","Q20.200x002","Q20.300","Q20.300x002","Q20.301","Q20.302","Q20.400","Q20.500","Q20.500x001","Q20.600","Q20.600x001","Q20.601","Q20.800x003","Q20.801","Q20.802","Q20.900","Q21.000","Q21.100","Q21.100x001","Q21.101","Q21.102","Q21.103","Q21.104","Q21.105","Q21.106","Q21.200","Q21.201","Q21.202","Q21.203","Q21.204","Q21.205","Q21.206","Q21.300x001","Q21.300x002","Q21.300x003","Q21.400x001","Q21.800","Q21.800x003","Q21.802","Q21.804","Q21.805","Q21.900","Q22.000","Q22.100","Q22.102","Q22.200","Q22.301","Q22.302","Q22.400","Q22.400x003","Q22.500","Q22.600","Q22.800x004","Q22.800x005","Q22.800x007","Q22.801","Q22.802","Q22.900","Q23.000","Q23.001","Q23.100","Q23.101","Q23.200","Q23.200x002","Q23.200x003","Q23.200x004","Q23.300","Q23.300x002","Q23.400","Q23.401","Q23.800","Q23.800x004","Q23.800x008","Q23.801","Q23.802","Q23.803","Q23.804","Q23.805","Q23.900x001","Q23.901","Q24.000x002","Q24.000x003","Q24.100","Q24.200","Q24.300","Q24.300x002","Q24.400","Q24.400x003","Q24.501","Q24.502","Q24.503","Q24.504","Q24.505","Q24.506","Q24.507","Q24.508","Q24.509","Q24.510","Q24.511","Q24.511","Q24.512","Q24.513","Q24.513","Q24.600x002","Q24.601","Q24.602","Q24.603","Q24.800","Q24.800x010","Q24.800x011","Q24.800x012","Q24.800x014","Q24.800x014","Q24.800x017","Q24.800x018","Q24.800x025","Q24.800x026","Q24.800x027","Q24.800x028","Q24.800x030","Q24.803","Q24.804","Q24.805","Q24.806","Q24.807","Q24.808","Q24.809","Q24.810","Q24.811","Q24.812","Q24.813","Q24.814","Q24.815","Q24.900","Q24.901","Q25.000","Q25.100","Q25.200","Q25.300","Q25.301","Q25.302","Q25.303","Q25.400x009","Q25.400x010","Q25.400x012","Q25.400x013","Q25.401","Q25.402","Q25.403","Q25.404","Q25.405","Q25.406","Q25.407","Q25.408","Q25.500","Q25.600","Q25.601","Q25.700x006","Q25.700x007","Q25.700x008","Q25.700x011","Q25.700x012","Q25.700x012","Q25.701","Q25.702","Q25.703","Q25.704","Q25.705","Q25.800x002","Q25.800x004","Q25.900","Q26.000x001","Q26.000x002","Q26.000x003","Q26.000x004","Q26.100","Q26.200x001","Q26.200x002","Q26.200x003","Q26.200x004","Q26.200x005","Q26.300","Q26.301","Q26.302","Q26.400","Q26.500","Q26.500x001","Q26.600","Q26.800x001","Q26.800x002","Q26.800x003","Q26.800x004","Q26.800x005","Q26.800x006","Q26.800x007","Q26.800x008","Q26.800x010","Q26.801","Q26.901","Q26.902","Q27.001","Q27.100","Q27.200x002","Q27.200x003","Q27.300x009","Q27.301","Q27.303","Q27.306","Q27.307","Q27.308","Q27.309","Q27.400","Q27.800x007","Q27.800x008","Q27.800x018","Q27.800x020","Q27.800x031","Q27.800x033","Q27.800x034","Q27.800x035","Q27.800x037","Q27.800x039","Q27.800x041","Q27.800x042","Q27.803","Q27.806","Q27.808","Q27.809","Q27.811","Q27.812","Q27.815","Q27.817","Q27.818","Q27.900","Q28.200x007","Q28.200x008","Q28.800x007","Q28.801","Q28.900","Q28.900x001","Q82.800x015","Q82.800x016","Q82.811","Q82.812","Q85.900x048","Q87.203","Q87.400","Q87.809","R00.000","R00.001","R00.100","R00.100x001","R00.200","R00.300","R00.800","R00.800x001","R00.800x003","R00.801","R01.000","R01.100","R01.200x003","R02.x00","R03.001","R03.100","R07.101","R07.200","R07.301","R07.400","R09.800x081","R09.800x082","R55.x00x001","R55.x00x002","R55.x00x003","R55.x00x004","R55.x00x005","R55.x00x006","R55.x00x007","R55.x00x008","R55.x00x009","R55.x00x010","R55.x00x011","R55.x00x012","R55.x00x013","R55.x00x014","R55.x02","R57.000","R57.100","R57.101","R57.200","R57.800x003","R57.801","R57.802","R57.803","R57.900","R57.900x002","R57.901","R68.800x001","R93.100x002","R93.101","R93.102","R93.103","R94.300","R94.300x003","R94.300x007","R94.300x010","R94.300x011","R94.300x011","R94.300x012","R94.301","R94.303","R94.304","R94.305","R94.306","R94.307","R94.308","R96.000x001","R96.001","S09.000x001","S15.000x002","S15.700x001","S25.000","S25.001","S25.100x002","S25.101","S25.200x001","S25.201","S25.300x001","S25.301","S25.400","S25.500","S25.501","S25.700","S25.800x003","S25.801","S25.802","S25.900","S26.000x001","S26.000x002","S26.010","S26.800x011","S26.800x021","S26.800x031","S26.800x082","S26.800x083","S26.801","S26.810","S26.811","S26.812","S26.813","S26.900","S26.910","S35.000","S35.001","S35.100","S35.100x003","S35.101","S35.102","S35.200x001","S35.200x003","S35.200x004","S35.200x005","S35.200x006","S35.200x007","S35.201","S35.202","S35.203","S35.204","S35.205","S35.300x001","S35.300x002","S35.300x003","S35.300x004","S35.300x005","S35.301","S35.302","S35.400x001","S35.400x002","S35.401","S35.402","S35.500x001","S35.500x002","S35.500x003","S35.500x004","S35.500x005","S35.500x006","S35.500x007","S35.500x008","S35.501","S35.502","S35.503","S35.700x001","S35.700x003","S35.700x004","S35.701","S35.800x001","S35.800x002","S35.801","S35.900x001","S35.901","S35.902","S35.903","S45.000","S45.001","S45.101","S45.200x002","S45.201","S45.300x001","S45.300x002","S45.301","S45.700x001","S45.701","S45.800","S45.900x001","S55.000x001","S55.100x001","S55.101","S55.200x001","S55.700x001","S55.800","S55.900x001","S65.000x001","S65.000x002","S65.100x001","S65.100x002","S65.200","S65.300","S65.400","S65.401","S65.500","S65.501","S65.700x001","S65.800","S65.900x001","S75.000","S75.000x002","S75.000x003","S75.000x004","S75.000x005","S75.001","S75.100x001","S75.100x002","S75.100x003","S75.200","S75.200x001","S75.700x001","S75.700x002","S75.800","S75.900x001","S75.900x002","S75.901","S85.000","S85.100x001","S85.100x002","S85.101","S85.102","S85.200","S85.300x001","S85.400x001","S85.500","S85.700x001","S85.800x001","S85.801","S85.900x001","S95.000","S95.100","S95.200","S95.700x001","S95.800","S95.900x001","T11.400","T13.400","T70.200x007","T79.100","T79.101","T80.000","T80.000x001","T80.100","T81.700x002","T81.700x003","T81.700x004","T81.700x005","T81.700x101","T81.700x102","T81.700x103","T81.700x104","T81.700x105","T81.700x201","T81.700x202","T81.700x203","T81.700x204","T81.700x205","T81.700x301","T81.700x302","T81.700x303","T81.700x304","T81.700x308","T81.700x401","T81.700x402","T81.700x403","T81.700x404","T81.700x405","T81.701","T81.702","T81.703","T81.800x010","T82.000","T82.000x001","T82.000x002","T82.001","T82.002","T82.003","T82.100","T82.100x002","T82.100x003","T82.100x005","T82.100x006","T82.100x007","T82.100x008","T82.100x009","T82.100x010","T82.100x011","T82.100x012","T82.100x013","T82.100x014","T82.100x015","T82.101","T82.102","T82.103","T82.201","T82.202","T82.300","T82.301","T82.302","T82.303","T82.400","T82.401","T82.500x001","T82.500x002","T82.500x003","T82.500x003","T82.501","T82.502","T82.503","T82.504","T82.600","T82.600x001","T82.601","T82.700","T82.702","T82.703","T82.704","T82.800x001","T82.800x003","T82.800x004","T82.800x005","T82.800x006","T82.800x008","T82.800x009","T82.800x101","T82.800x102","T82.800x103","T82.800x104","T82.800x105","T82.800x106","T82.800x201","T82.800x202","T82.800x203","T82.800x204","T82.800x205","T82.800x206","T82.800x207","T82.800x208","T82.800x301","T82.800x302","T82.800x303","T82.800x304","T82.800x305","T82.800x306","T82.800x307","T82.800x308","T82.800x401","T82.800x402","T82.800x403","T82.800x404","T82.800x405","T82.800x406","T82.800x407","T82.800x408","T82.800x409","T82.800x410","T82.800x411","T82.801","T82.803","T82.804","T82.805","T82.806","T82.807","T82.808","T82.809","T82.810","T82.811","T82.814","T82.900x001","T82.900x002","T82.901","T82.903","T82.904","T86.200x001","T86.200x002","T86.300x001","T86.300x002","Z03.400","Z03.500x001","Z03.501","Z45.001","Z45.002","Z45.003","Z45.005","Z45.006","Z45.800x006","Z52.700"};
            String[] dept_list={};
            if (!(true && mdc_zd.Contains(record.zdList[0]))){
                return "";
            }
            
            Base.groupMessages.putMessage(record.Index,"符合MDCF入组条件，匹配规则：主诊断匹配");
            String result;
    
            result=FB1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=FB2.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=FC1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=FD1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=FD2.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=FD3.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=FE1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=FE2.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=FF2.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=FF1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=FF3.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=FJ1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=FK1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=FK2.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=FK3.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=FL1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=FL2.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=FL3.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=FM1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=FM2.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=FM3.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=FM4.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=FN1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=FN2.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=FP1.group(record);
            if (result.Length>0){
                return result;
            }
    
            if (false && record.ssList!=null && record.ssList.Length>0  && Base.intersect(Base.SS_VALID,record.ssList)){
                Base.groupMessages.putMessage(record.Index,"符合FQY入组条件，存在有效手术操作："+record.ssList.Intersect(Base.SS_VALID));
                return "FQY";
            }
    
            result=FR1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=FR2.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=FR3.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=FR4.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=FT1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=FT2.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=FT3.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=FT4.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=FU1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=FU2.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=FV1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=FV2.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=FV3.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=FW1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=FW2.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=FZ1.group(record);
            if (result.Length>0){
                return result;
            }
    
            Base.groupMessages.putMessage(record.Index,"不符合MDCF的ADRG入组条件");
            return "";
        }
    }
}
