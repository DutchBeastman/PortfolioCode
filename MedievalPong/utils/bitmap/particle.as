package utils.bitmap
{
	import flash.geom.Point;
	/**
	 * ...
	 * @author Kit
	 */
	public class particle extends MovableObject
	{
		public var xScale:int;
		public var xdisplace:int;
		public function particle(XP:int,YP:int,Speed:Number,Rotation:Number,LifeTime:int,SlowDown:Number,XScale:int,Xdisplace:int) 
		{
			super(XP, YP, Speed, Rotation, LifeTime, SlowDown)
			xScale = XScale;
			xdisplace = Xdisplace;
		}
		
		
	}

}