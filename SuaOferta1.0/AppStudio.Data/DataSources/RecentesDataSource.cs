using System;
using System.Windows;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppStudio.Data
{
    public class RecentesDataSource : DataSourceBase<RecentesSchema>
    {
        private const string _appId = "273701b5-211a-45de-9e22-6c8f42689220";
        private const string _dataSourceName = "f0415232-891a-46e0-b387-e975c34830c6";

        protected override string CacheKey
        {
            get { return "RecentesDataSource"; }
        }

        public override bool HasStaticData
        {
            get { return false; }
        }

        public async override Task<IEnumerable<RecentesSchema>> LoadDataAsync()
        {
            try
            {
                var serviceDataProvider = new ServiceDataProvider(_appId, _dataSourceName);
                return await serviceDataProvider.Load<RecentesSchema>();
            }
            catch (Exception ex)
            {
                AppLogs.WriteError("RecentesDataSource.LoadData", ex.ToString());
                return new RecentesSchema[0];
            }
        }
    }
}
