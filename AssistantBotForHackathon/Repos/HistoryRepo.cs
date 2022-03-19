using AssistantBotForHackathon.Entities;
using System.Collections.Generic;

namespace AssistantBotForHackathon.Repos
{
    public static class HistoryRepo
    {
        private static List<History> _historyList = new List<History>();
        public static List<History> GetHistoryList() => _historyList;

        public static void Add(History history) => _historyList.Add(history);
    }
}