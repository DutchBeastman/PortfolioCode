package sound 
{
	import flash.media.Sound;
	/**
	 * ...
	 * @author Kit van de Bunt
	 */
	public class SoundHolder 
	{
		public var name:String;
		public var _sound:Sound;
		public function SoundHolder(_name:String,_Sound:Sound) 
		{
			name = _name;
			_sound = _Sound;
		}
		
	}

}