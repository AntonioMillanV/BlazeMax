using System.Collections.Generic;
using veXMAX.Shared.Attributes;

namespace BlazeMaxControls.Components
{
	public class LayoutItem
	{
#nullable enable
		public List<LayoutItem>? GroupContent { get; set; } = new List<LayoutItem>();
		public VXLayOutGroupAttribute? GroupAttribute { get; set; } = null;

		public List<VXLayOutFieldAttribute>? LeafContent { get; set; } = new List<VXLayOutFieldAttribute>();
	}
}
