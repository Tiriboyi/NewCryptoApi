using Entities.Models;
using System.Collections.Generic;

namespace Interfaces
{
  public interface IRate
  {
    IEnumerable<Rate> GetRates();

    Rate GetRate(int id);

    void AddRate(Rate rate);

    void UpdateRate(Rate rate);

    void DeleteRate(int id);
  }
}