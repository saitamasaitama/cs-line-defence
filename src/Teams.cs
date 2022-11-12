
class Hero{
	int HP=		100;
	int ATK=	100;
	int Cast=	20;
	int ReCast=	40;

	string name;
	Action<TimeSpan> update;
	public static Hero Random(){
		Random r=new Random();
		return new Hero(){
			HP=r.Next(80,120)
		};
	
	}
}
class Team:List<Hero>{
	string name;
	public static Team Random(){
		Team result=new Team()
		result.Add(Hero.Random());
		result.Add(Hero.Random());
		result.Add(Hero.Random());
		result.Add(Hero.Random());
		result.Add(Hero.Random());
		return Team;
	}
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
		int frame=0;
		
		yield return new FrameUpdate();
		yield break;
	}
}

class FrameUpdate{



}
