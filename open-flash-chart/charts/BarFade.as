package charts {
	import charts.series.Element;
	import charts.Elements.PointBarFade;
	
	public class BarFade extends BarBase {
		
		public function BarFade( json:Object, group:Number, collection:ObjectCollection ) {
			super( json, group, collection );
		}
		
		//
		// called from the base object
		//
		protected override function get_element( index:Number, value:Object ): Element {
			return new PointBarFade( index, value, this.colour, this.group );
		}
	}
}