﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using PlayStationSharp.Model.TrophyJsonTypes;

namespace PlayStationSharp.Model.TrophyJsonTypes
{
	public class DefinedTrophies
	{

		[JsonProperty("bronze")]
		public int Bronze { get; set; }

		[JsonProperty("silver")]
		public int Silver { get; set; }

		[JsonProperty("gold")]
		public int Gold { get; set; }

		[JsonProperty("platinum")]
		public int Platinum { get; set; }
	}

	public class EarnedTrophies
	{

		[JsonProperty("bronze")]
		public int Bronze { get; set; }

		[JsonProperty("silver")]
		public int Silver { get; set; }

		[JsonProperty("gold")]
		public int Gold { get; set; }

		[JsonProperty("platinum")]
		public int Platinum { get; set; }
	}

	public class ComparedUser
	{

		[JsonProperty("onlineId")]
		public string OnlineId { get; set; }

		[JsonProperty("progress")]
		public int Progress { get; set; }

		[JsonProperty("earnedTrophies")]
		public EarnedTrophies EarnedTrophies { get; set; }

		[JsonProperty("lastUpdateDate")]
		public string LastUpdateDate { get; set; }
	}

	public class EarnedTrophies2
	{

		[JsonProperty("bronze")]
		public int Bronze { get; set; }

		[JsonProperty("silver")]
		public int Silver { get; set; }

		[JsonProperty("gold")]
		public int Gold { get; set; }

		[JsonProperty("platinum")]
		public int Platinum { get; set; }
	}

	public class FromUser
	{

		[JsonProperty("onlineId")]
		public string OnlineId { get; set; }

		[JsonProperty("progress")]
		public int Progress { get; set; }

		[JsonProperty("earnedTrophies")]
		public EarnedTrophies2 EarnedTrophies { get; set; }

		[JsonProperty("hiddenFlag")]
		public bool HiddenFlag { get; set; }

		[JsonProperty("lastUpdateDate")]
		public string LastUpdateDate { get; set; }
	}

	public class TrophyTitle
	{

		[JsonProperty("npCommunicationId")]
		public string NpCommunicationId { get; set; }

		[JsonProperty("trophyTitleName")]
		public string TrophyTitleName { get; set; }

		[JsonProperty("trophyTitleDetail")]
		public string TrophyTitleDetail { get; set; }

		[JsonProperty("trophyTitleIconUrl")]
		public string TrophyTitleIconUrl { get; set; }

		[JsonProperty("trophyTitleSmallIconUrl")]
		public string TrophyTitleSmallIconUrl { get; set; }

		[JsonProperty("trophyTitlePlatfrom")]
		public string TrophyTitlePlatfrom { get; set; }

		[JsonProperty("hasTrophyGroups")]
		public bool HasTrophyGroups { get; set; }

		[JsonProperty("definedTrophies")]
		public DefinedTrophies DefinedTrophies { get; set; }

		[JsonProperty("comparedUser")]
		public ComparedUser ComparedUser { get; set; }

		[JsonProperty("fromUser")]
		public FromUser FromUser { get; set; }
		
		[JsonProperty("trophies")]
		public List<TrophyInfo> Trophies { get; set; }
		public override string ToString() => $"{NpCommunicationId}\t{TrophyTitleName}\t{TrophyTitlePlatfrom}";
        
    }

	public class TrophyEarnUser
	{
		[JsonProperty("onlineId")]
		public string OnlineId { get; set; }
		[JsonProperty("earned")]
		public bool Earned { get; set; }
		[JsonProperty("earnedDate")]
		public DateTime EarnedDate { get; set; }
	}

}

namespace PlayStationSharp.Model
{

	public class TrophyModel
	{

		[JsonProperty("totalResults")]
		public int TotalResults { get; set; }

		[JsonProperty("offset")]
		public int Offset { get; set; }

		[JsonProperty("limit")]
		public int Limit { get; set; }

		[JsonProperty("trophyTitles")]
		public IList<TrophyTitle> TrophyTitles { get; set; }
	}

	public class TrophyInfo
	{
		[JsonProperty("trophyId")]
		public int Id { get; set; }
		[JsonProperty("trophyHidden")]
		public bool isHidden { get; set; }
		[JsonProperty("trophyType")]
		public string Type { get; set; }
		[JsonProperty("trophyName")]
		public string Name { get; set; }
		[JsonProperty("trophyDetail")]
		public string Detail { get; set; }
		[JsonProperty("trophyIconUrl")]
		public string IconUrl { get; set; }
		[JsonProperty("trophyRare")]
		public int Rare { get; set; }
		[JsonProperty("trophyEarnedRate")]
		public string EarnedRate { get; set; }
		[JsonProperty("fromUser")]
		public TrophyEarnUser FromUser { get; set; }
		[JsonProperty("comparedUser")]
		public TrophyEarnUser CompareUser { get; set; }
	}

}
