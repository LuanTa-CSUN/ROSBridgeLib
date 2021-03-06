using ROSBridgeLib.Core;
using SimpleJSON;

/* 
 * @brief ROSBridgeLib
 * @author Michael Jenkin, Robert Codd-Downey, Andrew Speers and Miquel Massot Campos
 */

namespace ROSBridgeLib {
	namespace std_msgs {
		public class MultiArrayDimensionMsg : ROSBridgeMsg {
			private string _label;
            private uint _size, _stride;

			public override string ROSMessageType
			{
				get { return "std_msgs/MultiArrayDimension"; }
			}
			
			public MultiArrayDimensionMsg() {}
			
			public MultiArrayDimensionMsg(JSONNode msg) {
				_label = msg["label"];
				_size = uint.Parse(msg["size"]);
				_stride = uint.Parse(msg["stride"]);
			}
			
            public MultiArrayDimensionMsg(string label, uint size, uint stride) {
				_label = label;
                _size = size;
                _stride = stride;
			}

			public string GetLabel() {
				return _label;
			}

            public uint GetSize() {
                return _size;
            }

            public uint GetStride() {
                return _stride;
            }

			public override void Deserialize(JSONNode msg)
			{
				_label = msg["label"];
				_size = uint.Parse(msg["size"]);
				_stride = uint.Parse(msg["stride"]);
			}

			public override string ToString() {
				return ROSMessageType + " [label=" + _label + ", size=" + _size + ", stride = " + _stride + "]";
			}
			
			public override string ToYAMLString() {
                return "{\"label\" : " + _label + ",\"size\" :" + _size + ",\"stride\" :" + _stride + "}";
			}
		}
	}
}