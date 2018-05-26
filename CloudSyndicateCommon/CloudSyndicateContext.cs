using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace CloudSyndicateCommon
{
    public class CloudSyndicateContext : DbContext
    {
        public CloudSyndicateContext() : base("name=CloudSyndicateContext")
        {
        }

        public CloudSyndicateContext(string connString) : base(connString)
        {
        }

        public System.Data.Entity.DbSet<Ad> Ads { get; set; }
    
    }
}
