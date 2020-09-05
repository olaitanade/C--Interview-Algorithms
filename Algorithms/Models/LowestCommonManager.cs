using System;
using System.Collections.Generic;

namespace Algorithms.Models
{
    public class LowestCommonManager
    {
		public static OrgChart GetLowestCommonManager(OrgChart topManager, OrgChart reportOne,
  OrgChart reportTwo)
		{
			return getOrgInfo(topManager, reportOne, reportTwo).lowestCommonManager;
		}

		public static OrgInfo getOrgInfo(OrgChart manager, OrgChart reportOne, OrgChart reportTwo)
		{
			int numImportantReports = 0;
			foreach (OrgChart directReport in manager.directReports)
			{
				OrgInfo orgInfo = getOrgInfo(directReport, reportOne, reportTwo);
				if (orgInfo.lowestCommonManager != null) return orgInfo;
				numImportantReports += orgInfo.numImportantReports;
			}
			if (manager == reportOne || manager == reportTwo) numImportantReports++;
			OrgChart lowestCommonManager = numImportantReports == 2 ? manager : null;
			OrgInfo newOrgInfo = new OrgInfo(lowestCommonManager, numImportantReports);
			return newOrgInfo;
		}

		public class OrgChart
		{
			public char name;
			public List<OrgChart> directReports;

			public OrgChart(char name)
			{
				this.name = name;
				this.directReports = new List<OrgChart>();
			}

			// This method is for testing only.
			public void addDirectReports(OrgChart[] directReports)
			{
				foreach (OrgChart directReport in directReports)
				{
					this.directReports.Add(directReport);
				}
			}
		}

		public class OrgInfo
		{
			public OrgChart lowestCommonManager;
			public int numImportantReports;

			public OrgInfo(OrgChart lowestCommonManager, int numImportantReports)
			{
				this.lowestCommonManager = lowestCommonManager;
				this.numImportantReports = numImportantReports;
			}
		}
	}
}
