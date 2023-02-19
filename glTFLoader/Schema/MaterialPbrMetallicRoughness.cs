//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace glTFLoader.Schema {
    using System.Linq;
    using System.Runtime.Serialization;
    
    
    public class MaterialPbrMetallicRoughness {
        
        /// <summary>
        /// Backing field for BaseColorFactor.
        /// </summary>
        private float[] m_baseColorFactor = new float[] {
                1F,
                1F,
                1F,
                1F};
        
        /// <summary>
        /// Backing field for BaseColorTexture.
        /// </summary>
        private TextureInfo m_baseColorTexture;
        
        /// <summary>
        /// Backing field for MetallicFactor.
        /// </summary>
        private float m_metallicFactor = 1F;
        
        /// <summary>
        /// Backing field for RoughnessFactor.
        /// </summary>
        private float m_roughnessFactor = 1F;
        
        /// <summary>
        /// Backing field for MetallicRoughnessTexture.
        /// </summary>
        private TextureInfo m_metallicRoughnessTexture;
        
        /// <summary>
        /// Backing field for Extensions.
        /// </summary>
        private System.Collections.Generic.Dictionary<string, object> m_extensions;
        
        /// <summary>
        /// Backing field for Extras.
        /// </summary>
        private Extras m_extras;
        
        /// <summary>
        /// The factors for the base color of the material.
        /// </summary>
        [Newtonsoft.Json.JsonConverterAttribute(typeof(glTFLoader.Shared.ArrayConverter))]
        [Newtonsoft.Json.JsonPropertyAttribute("baseColorFactor")]
        public float[] BaseColorFactor {
            get {
                return this.m_baseColorFactor;
            }
            set {
                if ((value.Length < 4u)) {
                    throw new System.ArgumentException("Array not long enough");
                }
                if ((value.Length > 4u)) {
                    throw new System.ArgumentException("Array too long");
                }
                int index = 0;
                for (index = 0; (index < value.Length); index = (index + 1)) {
                    if ((value[index] < 0D)) {
                        throw new System.ArgumentOutOfRangeException();
                    }
                }
                for (index = 0; (index < value.Length); index = (index + 1)) {
                    if ((value[index] > 1D)) {
                        throw new System.ArgumentOutOfRangeException();
                    }
                }
                this.m_baseColorFactor = value;
            }
        }
        
        /// <summary>
        /// The base color texture.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseColorTexture")]
        public TextureInfo BaseColorTexture {
            get {
                return this.m_baseColorTexture;
            }
            set {
                this.m_baseColorTexture = value;
            }
        }
        
        /// <summary>
        /// The factor for the metalness of the material.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metallicFactor")]
        public float MetallicFactor {
            get {
                return this.m_metallicFactor;
            }
            set {
                if ((value < 0D)) {
                    throw new System.ArgumentOutOfRangeException("MetallicFactor", value, "Expected value to be greater than or equal to 0");
                }
                if ((value > 1D)) {
                    throw new System.ArgumentOutOfRangeException("MetallicFactor", value, "Expected value to be less than or equal to 1");
                }
                this.m_metallicFactor = value;
            }
        }
        
        /// <summary>
        /// The factor for the roughness of the material.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roughnessFactor")]
        public float RoughnessFactor {
            get {
                return this.m_roughnessFactor;
            }
            set {
                if ((value < 0D)) {
                    throw new System.ArgumentOutOfRangeException("RoughnessFactor", value, "Expected value to be greater than or equal to 0");
                }
                if ((value > 1D)) {
                    throw new System.ArgumentOutOfRangeException("RoughnessFactor", value, "Expected value to be less than or equal to 1");
                }
                this.m_roughnessFactor = value;
            }
        }
        
        /// <summary>
        /// The metallic-roughness texture.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metallicRoughnessTexture")]
        public TextureInfo MetallicRoughnessTexture {
            get {
                return this.m_metallicRoughnessTexture;
            }
            set {
                this.m_metallicRoughnessTexture = value;
            }
        }
        
        /// <summary>
        /// JSON object with extension-specific objects.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extensions")]
        public System.Collections.Generic.Dictionary<string, object> Extensions {
            get {
                return this.m_extensions;
            }
            set {
                this.m_extensions = value;
            }
        }
        
        /// <summary>
        /// Application-specific data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extras")]
        public Extras Extras {
            get {
                return this.m_extras;
            }
            set {
                this.m_extras = value;
            }
        }
        
        public bool ShouldSerializeBaseColorFactor() {
            return (m_baseColorFactor.SequenceEqual(new float[] {
                        1F,
                        1F,
                        1F,
                        1F}) == false);
        }
        
        public bool ShouldSerializeBaseColorTexture() {
            return ((m_baseColorTexture == null) 
                        == false);
        }
        
        public bool ShouldSerializeMetallicFactor() {
            return ((m_metallicFactor == 1F) 
                        == false);
        }
        
        public bool ShouldSerializeRoughnessFactor() {
            return ((m_roughnessFactor == 1F) 
                        == false);
        }
        
        public bool ShouldSerializeMetallicRoughnessTexture() {
            return ((m_metallicRoughnessTexture == null) 
                        == false);
        }
        
        public bool ShouldSerializeExtensions() {
            return ((m_extensions == null) 
                        == false);
        }
        
        public bool ShouldSerializeExtras() {
            return ((m_extras == null) 
                        == false);
        }
    }
}
