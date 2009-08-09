package charts {
	import charts.series.Element;
	import charts.series.bars.Bar3D;
	import string.Utils;
	
	
	public class Bar3D extends BarBase {
		
		public function Bar3D( json:Object, group:Number, collection:ObjectCollection) {
			super( json, group,collection );
		}
		
		//
		// called from the base object
		//
		protected override function get_element( index:Number, value:Object ): Element {
			var bar3d:charts.series.bars.Bar3D = new charts.series.bars.Bar3D( index, this.get_element_helper_prop( value ), this.group );
			bar3d.real_group = this.real_group;
			//tr.ace( "(get_element)this.real_group:" + this.real_group );
			return bar3d;
		}
		
	}
}