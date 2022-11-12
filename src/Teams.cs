
class Hero{
	int HP=		100;
	int ATK=	100;
	int Cast=	20;
	int ReCast=	40;

	string name;
	Action<TimeSpan> update;
}
class Team:List<Hero>{
	string name;
}
public class Axis{
	public enum TypeAxis{
		L,
		R
	}
	string name;
}
class Teams:List<(Axis.TypeAxis,Team)>{

}

class Battle{
	Teams teams;
	public static Battle From(Teams t){
		return new Battle(){
			teams=t
		};
	}
	IEnumerable<FrameUpdate> Start(){
		yield break;
	}
}

class FrameUpdate{}
