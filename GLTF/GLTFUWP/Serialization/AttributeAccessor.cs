﻿using GLTF;

namespace GLTF.Serialization
{
	public class AttributeAccessor
	{
		public AccessorId AccessorId { get; set; }
		public NumericArray AccessorContent { get; set; }
		public byte[] Buffer { get; set; }   // todo: should change to IntPtr?

		public AttributeAccessor()
		{
			AccessorContent = new NumericArray();
		}
	}
}