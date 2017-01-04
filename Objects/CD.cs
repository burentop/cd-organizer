using System.Collections.Generic;

namespace CDOrganizer.Objects
{
  public class CD
  {
    private string _title;
    private int _id;
    private static List<CD> _cds = new List<CD>{};
  }

  public CD(string title)
  {
    _title = title;
    _cds.Add(this);
    _id = _cds.Count;
  }

  public string GetTitle()
  {
    return _title;
  }

  public void SetTitle(string newTitle)
  {
    _title = newTitle;
  }

  public int GetId()
  {
    return _id;
  }

  public static List<CD> GetAll()
  {
    return _cds;
  }

  public static void ClearAll()
  {
    _cds.Clear();
  }

  public static CD Find(int searchId)
  {
    return _cds[searchId - 1];
  }
}
