package utils.bitmap
{
	import flash.display.BitmapData;
	import flash.display.DisplayObject;
	import flash.display.DisplayObjectContainer;
	import flash.display.Sprite;
	import flash.events.Event;
	import flash.events.MouseEvent;
	import flash.filters.ColorMatrixFilter;
	import flash.geom.ColorTransform;
	import flash.geom.Matrix;
	import flash.geom.Rectangle;
	import flash.ui.Mouse;
	import utils.Random;

	/**
	 * ...
	 * @author Kit van de bunt
	 */
	public class ParticleSystem extends Sprite
	{
		private var bitmapP1:DisplayObject;
		private var bitmapDataP1:BitmapData;
		private var particles:Array = new Array();
		public function ParticleSystem(particle_1:Class) 
		{
			if (stage) init();
			else addEventListener(Event.ADDED_TO_STAGE, init);
			
			bitmapP1 = new particle_1();
			bitmapDataP1 = new BitmapData(bitmapP1.width, bitmapP1.height, true);
			
			bitmapDataP1.draw(bitmapP1);
		}
		
		private function init(e:Event = null):void 
		{
			//canvas.setPixel32(10, 10, 0xffffffff);
		}
		
		private function colorfilt(alfa:Number):void {
			var matrix:Array = new Array();
            matrix=matrix.concat([alfa,0,0,0,0]);// red
            matrix=matrix.concat([0,alfa,0,0,0]);// green
            matrix=matrix.concat([0,0,alfa,0,0]);// blue
            matrix=matrix.concat([0,0,0,alfa,0]);// alpha
            var my_filter:ColorMatrixFilter = new ColorMatrixFilter(matrix);
            bitmapP1.filters=[my_filter];
		}
		
		/*public function click(m:MouseEvent):void {
			for (var j:int = 0; j < 50; j++) 
			{
				particles.push(new particle(mouseX, 
											mouseY, 
											((Math.random() * 1) + 1),
											(Math.random() * 2 * Math.PI),
											50 * Math.random() + 50 ,
											0.99));
			}
		}*/
		
		public function draw(xP:int,yP:int,systemRotation:Number,DrawTo:BitmapData,drawAmount:int,maxSpeed:Number,minSpeed:Number):void {
			//blur(8,8,2);
			
			for (var i:int = 0; i < particles.length - 1; i++) {
				particles[i].move();
				if(particles[i].lifeTime<0){
					particles.splice(i , 1);
				}else {
					var alfa:Number = particles[i].lifeTime / particles[i].startLifeTime;
					//trace(alfa);
					colorfilt(alfa)
					var mat:Matrix = new Matrix();
					mat.scale(particles[i].xScale, 1);
					if(particles[i].xScale!=1){
						mat.translate( bitmapDataP1.width , 0);
					}
					mat.translate(particles[i].xdisplace, 0);
					mat.translate(-bitmapDataP1.width / 2, -bitmapDataP1.width / 2);
					mat.rotate(particles[i].rotation + (90 / 180 * Math.PI));
					mat.translate(particles[i].xP , particles[i].yP );
					DrawTo.draw(bitmapP1,mat);
				}
			}
			
			for (var j:int = 0; j < drawAmount; j++) 
			{
				var scaleUpDown:int = Random.rangePosNum( 1, 3);
				var scaleX:int;
				if (scaleUpDown == 2) {
					scaleX = 1;
				}else {
					scaleX = -1;
				}
				particles.push(new particle(xP,
											yP, 
											Random.rangePosNum(maxSpeed,maxSpeed), 
											systemRotation + Random.rangePosNum( -0.3, 0.3) ,
											25 * Math.random() + 25,
											0.99,
											scaleX,
											Random.rangePosNum( -10, 10)
											));
			}
		}
	}

}