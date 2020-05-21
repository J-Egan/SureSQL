using SureSQL.Database.MySQL;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SureSQL.Parser
{
    public class parsedProcessor
    {
        public ConcurrentQueue<TreeItem> IncomingQueue;
        public int[] CompletedProcesses { get; set; }
        public TreeItem Parent{ get; set; }
        public MySQL mySql { get; set; }
        public Model Model{ get; set; }

        public parsedProcessor(Model model, TreeItem Parent)
        {
            this.IncomingQueue = new ConcurrentQueue<TreeItem>();
            this.CompletedProcesses = new int[4];
            this.Model = model;

            string server, username, password, database;
            server = Model.GetSingleProperty("server", out server);
            username = Model.GetSingleProperty("username", out username);
            password = Model.GetSingleProperty("password", out password);
            database = Model.GetSingleProperty("SelectedDatabase", out database);

            mySql = new MySQL(server, username, password, database);

            
        }

        public void startProcessing()
        {
            while (IncomingQueue.Count > 0
                && CompletedProcesses[0] != 1
                && CompletedProcesses[1] != 1
                && CompletedProcesses[2] != 1
                && CompletedProcesses[3] != 1)
            {
                //double check to ensure that there is an item available 
                if (IncomingQueue.Count > 0)
                {
                    //Process Queue
                    TreeItem item;
                    if (this.IncomingQueue.TryDequeue(out item))
                    {
                        string name;
                        
                        switch (item.DataType)
                        {
                            case (int)TreeItem.Type.FUNCTION:
                                // get function SQL
                                mySql.

                                // create a new parser
                                // send raw sql + parent node
                                parser_MySQL parse = new parser_MySQL(Model,)
                                // set as child of node passed in

                                break;
                            case (int)TreeItem.Type.PROCEDURE:
                                break;
                            case (int)TreeItem.Type.VIEW:
                                break;
                            case (int)TreeItem.Type.TABLE:
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }

        public void AddToQue(TreeItem item)
        {
            this.IncomingQueue.Enqueue(item);
        }
    }
}
