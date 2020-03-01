using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldCities.Data
{
	public class AppResult<T>
	{
		private ApiResult(
			List<T> data,
			int count,
			int pageIndex,
			int pageSize)
		{
			
		}
	}
}
