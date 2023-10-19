
using System.Collections.Generic;

namespace Walks
{
  public sealed class WalkRepository
  {
      private static readonly WalkRepository _instance = new WalkRepository();
      private List<Walk> _walks = new List<Walk>();

      // Explicit static constructor to tell C# compiler
      // not to mark type as beforefieldinit
      static WalkRepository()
      {
      }

      private WalkRepository()
      {
        this._walks.Add(new Walk(27, "Walk-27", "Pending"));
      }

      public static WalkRepository GetInstance()
      {
        return _instance;
      }

      public void AddWalk(Walk walk) {
        _walks.Add(walk);
      }

      public void RemoveWalks() {
        _walks.Clear();
      }

      public List<Walk> GetWalks() {
        return _walks;
      }

      public Walk GetWalk(int id) {
        return _walks.Find(walk => walk.Id == id);
      }
  }
}
