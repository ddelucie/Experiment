using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment
{
public interface IGuitar
{
	string PlaySolo(string notes);
}

public interface IAxe
{
	string PlaySolo(string notes);
}

public class LesPaul : IGuitar, IAxe
{
	public string PlaySolo(string notes)
	{
		return notes.ToUpper() + "!!";
	}
}

public class Strat : IGuitar, IAxe
{
	string IGuitar.PlaySolo(string notes)
	{
		return notes.ToUpper() + "  Guitar!!";
	}

	string IAxe.PlaySolo(string notes)
	{
		return notes.ToUpper() + "  Axe!!";
	}
}

}
