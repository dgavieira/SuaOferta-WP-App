using System;
using System.Windows;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppStudio.Data
{
    public class DestaquesDataSource : DataSourceBase<DestaquesSchema>
    {
        private const string _appId = "273701b5-211a-45de-9e22-6c8f42689220";
        private const string _dataSourceName = "a26bd6d5-f26a-4cf2-8dd3-84060b6c4716";

        protected override string CacheKey
        {
            get { return "DestaquesDataSource"; }
        }

        public override bool HasStaticData
        {
            get { return false; }
        }

        public async override Task<IEnumerable<DestaquesSchema>> LoadDataAsync()
        {
            try
            {
                var serviceDataProvider = new ServiceDataProvider(_appId, _dataSourceName);
                return await serviceDataProvider.Load<DestaquesSchema>();
            }
            catch (Exception ex)
            {
                AppLogs.WriteError("DestaquesDataSource.LoadData", ex.ToString());
                return new DestaquesSchema[0];
            }
        }
    }
}
