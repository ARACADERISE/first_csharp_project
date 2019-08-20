using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace network_configuration
{
    class a_simple_net_config
    {
        public class network
        {
            public string network_name { get; set; }
            public bool available { get; set; }
            
            public network(string networkname, string net_pass, bool is_available)
            {
                int TOTAL_AMOUNT = 50;
                string[] pass = new string[net_pass.Length];
                if (pass.Length > TOTAL_AMOUNT){
                    throw new Exception("Too Long Of A Password For Network: " + networkname);
                } else {
                    for (int i = 0; i < pass.Length; i++) {
                        pass[i] = "*";
                    }
                }
                char[] pass_is = new char[50];
                for (int i = 0; i < pass.Length; i++) {
                    pass_is[i] = '*';
                }
                network_name = networkname;
                available = is_available;
                
                Console.WriteLine("\n\nDATA\n\n\nNetwork Name: " + network_name);
                Console.Write("Password: ");
                Console.Write(pass_is);
                Console.WriteLine("\nAvailable: " + available);
            }
        }
        
        public class connect_net
        {
            public bool connection;
            public void con()
            {
                Console.Write("Network Name: ");
                string net_name = Console.ReadLine();
                Console.Write("Network Password: ");
                string net_pass = Console.ReadLine();
                Console.Write("Is Available[yes/no]: ");
                string available = Console.ReadLine();
                // true by default
                bool is_available = true;
                if(available == "Yes" || available == "yes") {
                    is_available = true;
                } else if(available == "No" || available == "no") {
                    is_available = false;
                }
                network net = new network(net_name, net_pass,is_available);
                
                if (is_available) {
                    this.connection = true;
                    while(this.connection) {
                        Console.WriteLine("Connected due to connectivity being " + this.connection);
                        break;
                    }
                } else {
                    this.connection = false;
                    while(this.connection != true) {
                      Console.WriteLine("Not connected due to connectivity being " + this.connection);
                      break;
                    }
                }
            }
        }
        
        public static void Main(string[] args)
        {
            try {
                //network net = new network(Console.ReadLine(),Console.ReadLine(),true);
                connect_net with_net = new connect_net();
                with_net.con();
            } catch (Exception) {
                Console.WriteLine("Error executing");
            }
        }
    }
}
