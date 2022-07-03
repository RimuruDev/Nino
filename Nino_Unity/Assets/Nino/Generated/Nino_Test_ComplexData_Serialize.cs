/* this is generated by nino */
namespace Nino.Test
{
    public partial class ComplexData
    {
        public static ComplexData.SerializationHelper NinoSerializationHelper = new ComplexData.SerializationHelper();
        public class SerializationHelper: Nino.Serialization.NinoWrapperBase<ComplexData>
        {
            #region NINO_CODEGEN
            public override void Serialize(ComplexData value, Nino.Serialization.Writer writer)
            {
                if(value.a != null)
                {
                    writer.CompressAndWrite(value.a.Length);
                    foreach (var entry in value.a)
                    {
                        if(entry != null)
                        {
                        	writer.CompressAndWrite(entry.Length);
                        	foreach (var entry0 in entry)
                        	{
                        		writer.CompressAndWrite(entry0);
                        	}
                        }
                        else
                        {
                        	writer.CompressAndWrite(0);
                        }
                    }
                }
                else
                {
                    writer.CompressAndWrite(0);
                }
                if(value.b != null)
                {
                    writer.CompressAndWrite(value.b.Count);
                    foreach (var entry in value.b)
                    {
                        if(entry != null)
                        {
                        	writer.CompressAndWrite(entry.Length);
                        	foreach (var entry0 in entry)
                        	{
                        		writer.CompressAndWrite(entry0);
                        	}
                        }
                        else
                        {
                        	writer.CompressAndWrite(0);
                        }
                    }
                }
                else
                {
                    writer.CompressAndWrite(0);
                }
                if(value.c != null)
                {
                    writer.CompressAndWrite(value.c.Length);
                    foreach (var entry in value.c)
                    {
                        if(entry != null)
                        {
                        	writer.CompressAndWrite(entry.Count);
                        	foreach (var entry0 in entry)
                        	{
                        		writer.CompressAndWrite(entry0);
                        	}
                        }
                        else
                        {
                        	writer.CompressAndWrite(0);
                        }
                    }
                }
                else
                {
                    writer.CompressAndWrite(0);
                }
                if(value.d != null)
                {
                    writer.CompressAndWrite(value.d.Count);
                    foreach (var entry in value.d)
                    {
                        writer.Write(entry.Key);
                        if(entry.Value != null)
                        {
                        	writer.CompressAndWrite(entry.Value.Count);
                        	foreach (var entry0 in entry.Value)
                        	{
                        		writer.Write(entry0.Key);
                        		writer.CompressAndWrite(entry0.Value);
                        	}
                        }
                        else
                        {
                        	writer.CompressAndWrite(0);
                        }
                    }
                }
                else
                {
                    writer.CompressAndWrite(0);
                }
                if(value.e != null)
                {
                    writer.CompressAndWrite(value.e.Length);
                    foreach (var entry in value.e)
                    {
                        if(entry != null)
                        {
                        	writer.CompressAndWrite(entry.Count);
                        	foreach (var entry0 in entry)
                        	{
                        		writer.Write(entry0.Key);
                        	    if(entry0.Value != null)
                        	    {
                        		    writer.CompressAndWrite(entry0.Value.Count);
                        		    foreach (var entry1 in entry0.Value)
                        		    {
                        			    writer.Write(entry1.Key);
                        		        if(entry1.Value != null)
                        		        {
                        			        writer.CompressAndWrite(entry1.Value.Length);
                        			        foreach (var entry2 in entry1.Value)
                        			        {
                        			            if(entry2 != null)
                        			            {
                        				            writer.CompressAndWrite(entry2.Length);
                        				            foreach (var entry3 in entry2)
                        				            {
                        					            writer.CompressAndWrite(entry3);
                        				            }
                        			            }
                        			            else
                        			            {
                        				            writer.CompressAndWrite(0);
                        			            }
                        			        }
                        		        }
                        		        else
                        		        {
                        			        writer.CompressAndWrite(0);
                        		        }
                        		    }
                        	    }
                        	    else
                        	    {
                        		    writer.CompressAndWrite(0);
                        	    }
                        	}
                        }
                        else
                        {
                        	writer.CompressAndWrite(0);
                        }
                    }
                }
                else
                {
                    writer.CompressAndWrite(0);
                }
                if(value.f != null)
                {
                    writer.CompressAndWrite(value.f.Length);
                    foreach (var entry in value.f)
                    {
                        if(entry != null)
                        {
                        	writer.CompressAndWrite(entry.Length);
                        	foreach (var entry0 in entry)
                        	{
                        		Nino.Test.Data.NinoSerializationHelper.Serialize(entry0, writer);
                        	}
                        }
                        else
                        {
                        	writer.CompressAndWrite(0);
                        }
                    }
                }
                else
                {
                    writer.CompressAndWrite(0);
                }
                if(value.g != null)
                {
                    writer.CompressAndWrite(value.g.Count);
                    foreach (var entry in value.g)
                    {
                        if(entry != null)
                        {
                        	writer.CompressAndWrite(entry.Length);
                        	foreach (var entry0 in entry)
                        	{
                        		Nino.Test.Data.NinoSerializationHelper.Serialize(entry0, writer);
                        	}
                        }
                        else
                        {
                        	writer.CompressAndWrite(0);
                        }
                    }
                }
                else
                {
                    writer.CompressAndWrite(0);
                }
                if(value.h != null)
                {
                    writer.CompressAndWrite(value.h.Length);
                    foreach (var entry in value.h)
                    {
                        if(entry != null)
                        {
                        	writer.CompressAndWrite(entry.Length);
                        	foreach (var entry0 in entry)
                        	{
                        	    if(entry0 != null)
                        	    {
                        		    writer.CompressAndWrite(entry0.Length);
                        		    foreach (var entry1 in entry0)
                        		    {
                        			    Nino.Test.Data.NinoSerializationHelper.Serialize(entry1, writer);
                        		    }
                        	    }
                        	    else
                        	    {
                        		    writer.CompressAndWrite(0);
                        	    }
                        	}
                        }
                        else
                        {
                        	writer.CompressAndWrite(0);
                        }
                    }
                }
                else
                {
                    writer.CompressAndWrite(0);
                }
                if(value.i != null)
                {
                    writer.CompressAndWrite(value.i.Length);
                    foreach (var entry in value.i)
                    {
                        if(entry != null)
                        {
                        	writer.CompressAndWrite(entry.Count);
                        	foreach (var entry0 in entry)
                        	{
                        		Nino.Test.Data.NinoSerializationHelper.Serialize(entry0, writer);
                        	}
                        }
                        else
                        {
                        	writer.CompressAndWrite(0);
                        }
                    }
                }
                else
                {
                    writer.CompressAndWrite(0);
                }
                if(value.j != null)
                {
                    writer.CompressAndWrite(value.j.Length);
                    foreach (var entry in value.j)
                    {
                        if(entry != null)
                        {
                        	writer.CompressAndWrite(entry.Count);
                        	foreach (var entry0 in entry)
                        	{
                        	    if(entry0 != null)
                        	    {
                        		    writer.CompressAndWrite(entry0.Length);
                        		    foreach (var entry1 in entry0)
                        		    {
                        			    Nino.Test.Data.NinoSerializationHelper.Serialize(entry1, writer);
                        		    }
                        	    }
                        	    else
                        	    {
                        		    writer.CompressAndWrite(0);
                        	    }
                        	}
                        }
                        else
                        {
                        	writer.CompressAndWrite(0);
                        }
                    }
                }
                else
                {
                    writer.CompressAndWrite(0);
                }
            }

            public override Nino.Serialization.Box<ComplexData> Deserialize(Nino.Serialization.Reader reader)
            {
                ComplexData value = new ComplexData();
                value.a = new System.Int32[reader.ReadLength()][];
                for(int i = 0, cnt = value.a.Length; i < cnt; i++)
                {
                    var value_a_i = new System.Int32[reader.ReadLength()];
                	for(int value_a_i_i = 0, value_a_i_cnt = value_a_i.Length; value_a_i_i < value_a_i_cnt; value_a_i_i++)
                	{
                		var value_value_a_i_i =  (System.Int32)reader.DecompressAndReadNumber();
                		value_a_i[value_a_i_i] = value_value_a_i_i;
                	}
                    value.a[i] = value_a_i;
                }
                value.b = new System.Collections.Generic.List<System.Int32[]>(reader.ReadLength());
                for(int i = 0, cnt = value.b.Capacity; i < cnt; i++)
                {
                    var value_b_i = new System.Int32[reader.ReadLength()];
                	for(int value_b_i_i = 0, value_b_i_cnt = value_b_i.Length; value_b_i_i < value_b_i_cnt; value_b_i_i++)
                	{
                		var value_value_b_i_i =  (System.Int32)reader.DecompressAndReadNumber();
                		value_b_i[value_b_i_i] = value_value_b_i_i;
                	}
                    value.b.Add(value_b_i);
                }
                value.c = new System.Collections.Generic.List<System.Int32>[reader.ReadLength()];
                for(int i = 0, cnt = value.c.Length; i < cnt; i++)
                {
                    var value_c_i = new System.Collections.Generic.List<System.Int32>(reader.ReadLength());
                	for(int value_c_i_i = 0, value_c_i_cnt = value_c_i.Capacity; value_c_i_i < value_c_i_cnt; value_c_i_i++)
                	{
                		var value_value_c_i_i =  (System.Int32)reader.DecompressAndReadNumber();
                		value_c_i.Add(value_value_c_i_i);
                	}
                    value.c[i] = value_c_i;
                }
                var value_d_len = reader.ReadLength();
                value.d = new System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.Dictionary<System.String,System.Int32>>(value_d_len);
                for(int i = 0; i < value_d_len; i++)
                {
                    var value_d_key = reader.ReadString();
                	var value_d_val_len = reader.ReadLength();
                	var value_d_val = new System.Collections.Generic.Dictionary<System.String,System.Int32>(value_d_val_len);
                	for(int value_d_val_i = 0; value_d_val_i < value_d_val_len; value_d_val_i++)
                	{
                		var value_d_val_key = reader.ReadString();
                		var value_d_val_val =  (System.Int32)reader.DecompressAndReadNumber();
                		value_d_val[value_d_val_key] = value_d_val_val;
                	}
                    value.d[value_d_key] = value_d_val;
                }
                value.e = new System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.Dictionary<System.String,System.Int32[][]>>[reader.ReadLength()];
                for(int i = 0, cnt = value.e.Length; i < cnt; i++)
                {
                 	var value_e_i_len = reader.ReadLength();
                	var value_e_i = new System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.Dictionary<System.String,System.Int32[][]>>(value_e_i_len);
                	for(int value_e_i_i = 0; value_e_i_i < value_e_i_len; value_e_i_i++)
                	{
                		var value_e_i_key = reader.ReadString();
                		var value_e_i_val_len = reader.ReadLength();
                		var value_e_i_val = new System.Collections.Generic.Dictionary<System.String,System.Int32[][]>(value_e_i_val_len);
                		for(int value_e_i_val_i = 0; value_e_i_val_i < value_e_i_val_len; value_e_i_val_i++)
                		{
                			var value_e_i_val_key = reader.ReadString();
                			var value_e_i_val_val = new System.Int32[reader.ReadLength()][];
                			for(int value_e_i_val_val_i = 0, value_e_i_val_val_cnt = value_e_i_val_val.Length; value_e_i_val_val_i < value_e_i_val_val_cnt; value_e_i_val_val_i++)
                			{
                				var value_value_e_i_val_val_i = new System.Int32[reader.ReadLength()];
                				for(int value_value_e_i_val_val_i_i = 0, value_value_e_i_val_val_i_cnt = value_value_e_i_val_val_i.Length; value_value_e_i_val_val_i_i < value_value_e_i_val_val_i_cnt; value_value_e_i_val_val_i_i++)
                				{
                					var value_value_value_e_i_val_val_i_i =  (System.Int32)reader.DecompressAndReadNumber();
                					value_value_e_i_val_val_i[value_value_e_i_val_val_i_i] = value_value_value_e_i_val_val_i_i;
                				}
                				value_e_i_val_val[value_e_i_val_val_i] = value_value_e_i_val_val_i;
                			}
                			value_e_i_val[value_e_i_val_key] = value_e_i_val_val;
                		}

                		value_e_i[value_e_i_key] = value_e_i_val;
                	}
                    value.e[i] = value_e_i;
                }
                value.f = new Nino.Test.Data[reader.ReadLength()][];
                for(int i = 0, cnt = value.f.Length; i < cnt; i++)
                {
                    var value_f_i = new Nino.Test.Data[reader.ReadLength()];
                	for(int value_f_i_i = 0, value_f_i_cnt = value_f_i.Length; value_f_i_i < value_f_i_cnt; value_f_i_i++)
                	{
                		var value_value_f_i_i = Nino.Test.Data.NinoSerializationHelper.Deserialize(reader).RetrieveValueAndReturn();
                		value_f_i[value_f_i_i] = value_value_f_i_i;
                	}
                    value.f[i] = value_f_i;
                }
                value.g = new System.Collections.Generic.List<Nino.Test.Data[]>(reader.ReadLength());
                for(int i = 0, cnt = value.g.Capacity; i < cnt; i++)
                {
                    var value_g_i = new Nino.Test.Data[reader.ReadLength()];
                	for(int value_g_i_i = 0, value_g_i_cnt = value_g_i.Length; value_g_i_i < value_g_i_cnt; value_g_i_i++)
                	{
                		var value_value_g_i_i = Nino.Test.Data.NinoSerializationHelper.Deserialize(reader).RetrieveValueAndReturn();
                		value_g_i[value_g_i_i] = value_value_g_i_i;
                	}
                    value.g.Add(value_g_i);
                }
                value.h = new Nino.Test.Data[reader.ReadLength()][][];
                for(int i = 0, cnt = value.h.Length; i < cnt; i++)
                {
                    var value_h_i = new Nino.Test.Data[reader.ReadLength()][];
                	for(int value_h_i_i = 0, value_h_i_cnt = value_h_i.Length; value_h_i_i < value_h_i_cnt; value_h_i_i++)
                	{
                		var value_value_h_i_i = new Nino.Test.Data[reader.ReadLength()];
                		for(int value_value_h_i_i_i = 0, value_value_h_i_i_cnt = value_value_h_i_i.Length; value_value_h_i_i_i < value_value_h_i_i_cnt; value_value_h_i_i_i++)
                		{
                			var value_value_value_h_i_i_i = Nino.Test.Data.NinoSerializationHelper.Deserialize(reader).RetrieveValueAndReturn();
                			value_value_h_i_i[value_value_h_i_i_i] = value_value_value_h_i_i_i;
                		}
                		value_h_i[value_h_i_i] = value_value_h_i_i;
                	}
                    value.h[i] = value_h_i;
                }
                value.i = new System.Collections.Generic.List<Nino.Test.Data>[reader.ReadLength()];
                for(int i = 0, cnt = value.i.Length; i < cnt; i++)
                {
                    var value_i_i = new System.Collections.Generic.List<Nino.Test.Data>(reader.ReadLength());
                	for(int value_i_i_i = 0, value_i_i_cnt = value_i_i.Capacity; value_i_i_i < value_i_i_cnt; value_i_i_i++)
                	{
                		var value_value_i_i_i = Nino.Test.Data.NinoSerializationHelper.Deserialize(reader).RetrieveValueAndReturn();
                		value_i_i.Add(value_value_i_i_i);
                	}
                    value.i[i] = value_i_i;
                }
                value.j = new System.Collections.Generic.List<Nino.Test.Data[]>[reader.ReadLength()];
                for(int i = 0, cnt = value.j.Length; i < cnt; i++)
                {
                    var value_j_i = new System.Collections.Generic.List<Nino.Test.Data[]>(reader.ReadLength());
                	for(int value_j_i_i = 0, value_j_i_cnt = value_j_i.Capacity; value_j_i_i < value_j_i_cnt; value_j_i_i++)
                	{
                		var value_value_j_i_i = new Nino.Test.Data[reader.ReadLength()];
                		for(int value_value_j_i_i_i = 0, value_value_j_i_i_cnt = value_value_j_i_i.Length; value_value_j_i_i_i < value_value_j_i_i_cnt; value_value_j_i_i_i++)
                		{
                			var value_value_value_j_i_i_i = Nino.Test.Data.NinoSerializationHelper.Deserialize(reader).RetrieveValueAndReturn();
                			value_value_j_i_i[value_value_j_i_i_i] = value_value_value_j_i_i_i;
                		}
                		value_j_i.Add(value_value_j_i_i);
                	}
                    value.j[i] = value_j_i;
                }
                var ret = Nino.Shared.IO.ObjectPool<Nino.Serialization.Box<Nino.Test.ComplexData>>.Request();
                ret.Value = value;
                return ret;
            }
            #endregion
        }
    }
}