using PlayStationSharp.Model;
using PlayStationSharp.Model.TrophyJsonTypes;
using System;
using System.Collections.Generic;

namespace PlayStationSharp.API
{
	public class Trophy : IPlayStation
	{
		private Lazy<List<TrophyInfo>> _trophyInfo;

		public PlayStationClient Client { get; private set; }
		public TrophyTitle Information { get; private set; }
		public List<TrophyInfo> TrophyInformation => _trophyInfo.Value;

		public Trophy(PlayStationClient client, TrophyTitle trophy)
		{
			Client = client;
			Information = trophy;
			_trophyInfo = new Lazy<List<TrophyInfo>>(GetTrophiesInformation);

		}

		/// <summary>
		/// Deletes the game from showing up under the user's trophies list (only works if the game has 0% of trophies obtained).
		/// </summary>
		/// <param name="gameContentId">The content Id of the game. (ex: NPWR07466_00)</param>
		/// <returns>True if the trophy was successfully deleted.</returns>
		public bool DeleteTrophy()
		{
			Request.SendDeleteRequest<object>($"https://us-tpy.np.community.playstation.net/trophy/v1/users/{ this.Client.Account.OnlineId}/trophyTitles/{ Information.NpCommunicationId }",
				this.Client.Tokens.Authorization);

			return true;
		}

		/// <summary>
		/// Fill and get all the trophies of the game related to the TrophyTitle
		/// </summary>
		/// <returns></returns>
		private List<TrophyInfo> GetTrophiesInformation()
        {
			var url = $"https://us-tpy.np.community.playstation.net/trophy/v1/trophyTitles/{Information.NpCommunicationId}/trophyGroups/all/trophies?fields=@default,trophyRare,trophyEarnedRate&npLanguage=en&sortKey=trophyId&iconSize=m";			
				if (Information.ComparedUser != null) url += $"&comparedUser={Information.ComparedUser.OnlineId}";
			
			var t =  Request.SendGetRequest<TrophyTitle>(url,Client.Tokens.Authorization).Trophies;
			
			Information.Trophies = t;
			
			return Information.Trophies;
		}

		/// <summary>
		/// Gets the trophies of a game.
		/// </summary>
		/// <param name="gameContentId">The content Id of the game. (ex: NPWR07466_00)</param>
		/// <returns>GameTrophiesResponse object containing a list of all the trophies.</returns>
		//public static TrophyResponses.GameTrophiesResponse GetGameTrophies(string gameContentId)
		//{
		//	return Request.SendGetRequest<TrophyResponses.GameTrophiesResponse>($"https://us-tpy.np.community.playstation.net/trophy/v1/trophyTitles/{gameContentId}/trophyGroups/all/trophies?fields=@default,trophyRare,trophyEarnedRate&npLanguage=en&sortKey=trophyId&iconSize=m",
		//		Auth.CurrentInstance.AccountTokens.Authorization);
		//}

	}
}