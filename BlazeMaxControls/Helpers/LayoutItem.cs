using System;
using System.Collections.Generic;
using System.Linq;
using veXMAX.Shared.Attributes;
using veXMAX.Shared.Models;
using veXMAX.Shared.Models.Transactions;

namespace BlazeMaxControls.Components
{
	public class LayoutItem
	{
#nullable enable
		public ERCAJ_BANCO Model { get; set; }
		public List<LayoutItem>? GroupContent { get; set; } = new List<LayoutItem>();
		public VXLayOutGroupAttribute? GroupAttribute { get; set; } = null;

		public List<VXLayOutFieldAttribute>? LeafContent { get; set; } = new List<VXLayOutFieldAttribute>();
		private List<VXLayOutGroupAttribute> VXGroups
		{
			get => typeof(ERCAJ_BANCO).GetCustomAttributes(typeof(VXLayOutGroupAttribute), false).Cast<VXLayOutGroupAttribute>().ToList();
		}
		private List<VXLayOutFieldAttribute> VXFields
		{
			get => typeof(ERCAJ_BANCO).GetCustomAttributes(typeof(VXLayOutFieldAttribute), false).Cast<VXLayOutFieldAttribute>().ToList();
		}
		public LayoutItem OrganizeLayout()
		{
			LayoutItem Root = new LayoutItem();

			var rootAttributes = VXGroups.FindAll(gr => gr.ParentGroup == string.Empty && gr.Order == 0 && gr.Primitive == string.Empty);

			if (rootAttributes.Count > 1)
				throw new Exception("No puede existir mas de un grupo Raíz");

			if (rootAttributes.Count == 0)
			{
				Root = new LayoutItem
				{
					GroupAttribute = new VXLayOutGroupAttribute
					{
						ParentGroup = string.Empty,
						Description = string.Empty,
						BeginRow = false,
						BorderType = VXLayOutGroupBorderTypeEnum.Ligth,
						CollapseButton = true,
						ColSpan = 12,
						ContainerType = VXLayOutGroupEnum.GroupContainer,
						Group = "",
						IsTab = false,
						Order = 0
					},
				};
				Root.GroupContent = NestGroupsAndFields(Root.GroupAttribute.Group, VXGroups);
			}
			if (rootAttributes.Count == 1)
			{
				Root = new LayoutItem
				{
					GroupAttribute = rootAttributes[0],
					GroupContent = NestGroupsAndFields(rootAttributes[0].Group, VXGroups.Where(gr => gr != rootAttributes[0]).ToList())
				};
			}

			return Root;
		}
		public List<LayoutItem> NestGroupsAndFields(string ParentGroupName, List<VXLayOutGroupAttribute> Groups)
		{
			List<VXLayOutGroupAttribute> iterativeGroups = Groups;

			List<LayoutItem> ResultList = new List<LayoutItem>();

			foreach (var group in iterativeGroups.Where(gr => gr.ParentGroup == ParentGroupName).OrderBy(gr => gr.Order))
			{
				LayoutItem layoutItem = new LayoutItem()
				{ GroupAttribute = group };

				if (VXFields.Where(field => field.Group == group.Group).ToList().Count > 0)
				{
					layoutItem.LeafContent = VXFields.Where(field => field.Group == group.Group).OrderBy(field => field.Order).ToList();
				}

				if (iterativeGroups.Remove(group))
					layoutItem.GroupContent = NestGroupsAndFields(group.Group, iterativeGroups);
				else
					layoutItem.GroupContent = NestGroupsAndFields(group.Group, iterativeGroups.Where(gr => gr != group).ToList());

				ResultList.Add(layoutItem);
			}

			return ResultList;
		}
		public List<LayoutItem> OrganizeLayoutLeafContent()
		{
			LayoutItem Root = new LayoutItem();
			List<LayoutItem> ResultList = new List<LayoutItem>();

			var rootAttributes = VXGroups;
			//var rootAttributes2 = VXGroups.FindAll(gr => gr.Primitive == string.Empty);

			//if (rootAttributes.Count > 1)
			//	throw new Exception("No puede existir mas de un grupo Raíz");

			if (rootAttributes.Count == 0)
			{
				Root = new LayoutItem
				{
					GroupAttribute = new VXLayOutGroupAttribute
					{
						ParentGroup = string.Empty,
						Description = string.Empty,
						BeginRow = false,
						BorderType = VXLayOutGroupBorderTypeEnum.Ligth,
						CollapseButton = true,
						ColSpan = 12,
						ContainerType = VXLayOutGroupEnum.GroupContainer,
						Group = "",
						IsTab = false,
						Order = 0
					},
				};
				Root.GroupContent = NestGroupsAndFields(Root.GroupAttribute.Group, VXGroups);
			}
			if (rootAttributes.Count > 0)
			{
                for (int i = 0; i < rootAttributes.Count; i++)
                {
					Root = new LayoutItem
					{
						GroupAttribute = rootAttributes[i],
						GroupContent = NestGroupsAndFieldsLeafContent(rootAttributes[i].Group, VXGroups.Where(gr => gr != rootAttributes[i]).ToList())
					};

					ResultList.Add(Root);
				}
				
			}
			
			return ResultList;
		}
		public List<LayoutItem> NestGroupsAndFieldsLeafContent(string ParentGroupName, List<VXLayOutGroupAttribute> Groups)
		{
			List<VXLayOutGroupAttribute> iterativeGroups = Groups;

			List<LayoutItem> ResultList = new List<LayoutItem>();

			foreach (var group in iterativeGroups.Where(gr => gr.ParentGroup == ParentGroupName).OrderBy(gr => gr.Order))
			{
				LayoutItem layoutItem = new LayoutItem()
				{ GroupAttribute = group };

				if (VXFields.Where(field => field.Group == group.Group).ToList().Count > 0)
				{
					layoutItem.LeafContent = VXFields.Where(field => field.Group == group.Group).OrderBy(field => field.Order).ToList();
					ResultList.Add(layoutItem);
				}
				
			}

			return ResultList;
		}
	}
}
