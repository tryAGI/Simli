
#nullable enable

namespace Simli
{
    /// <summary>
    /// Camera offsets on top of the avatar's own framing. Every field is optional and neutral when left out. A value outside its supported range is still applied, and the response lists a warning for it; NaN and infinity are a 422.
    /// </summary>
    public sealed partial class CameraSetting
    {
        /// <summary>
        /// Moves the avatar right, in half canvas widths. Supported range -10 to 10.<br/>
        /// Default Value: 0.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pos_x_off")]
        public double? PosXOff { get; set; }

        /// <summary>
        /// Moves the avatar down, in half canvas heights. Supported range -10 to 10.<br/>
        /// Default Value: 0.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pos_y_off")]
        public double? PosYOff { get; set; }

        /// <summary>
        /// Metres the camera backs away from the avatar (negative moves in). Supported range -5 to 5.<br/>
        /// Default Value: 0.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pos_z_off")]
        public double? PosZOff { get; set; }

        /// <summary>
        /// Degrees the camera tilts up (pitch). Supported range -180 to 180.<br/>
        /// Default Value: 0.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rot_x_off")]
        public double? RotXOff { get; set; }

        /// <summary>
        /// Degrees the camera pans right (yaw). Supported range -180 to 180.<br/>
        /// Default Value: 0.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rot_y_off")]
        public double? RotYOff { get; set; }

        /// <summary>
        /// Degrees the camera rolls clockwise. Supported range -180 to 180.<br/>
        /// Default Value: 0.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rot_z_off")]
        public double? RotZOff { get; set; }

        /// <summary>
        /// Multiplies the avatar's zoom; 1 is no change. Supported range above 0, up to 4.<br/>
        /// Default Value: 1.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zoom")]
        public double? Zoom { get; set; }

        /// <summary>
        /// Degrees the camera orbits up over the avatar's head (elevation). Supported range -80 to 80.<br/>
        /// Default Value: 0.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orbit_x_off")]
        public double? OrbitXOff { get; set; }

        /// <summary>
        /// Degrees the camera orbits round to its right (azimuth). Supported range -180 to 180.<br/>
        /// Default Value: 0.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orbit_y_off")]
        public double? OrbitYOff { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CameraSetting" /> class.
        /// </summary>
        /// <param name="posXOff">
        /// Moves the avatar right, in half canvas widths. Supported range -10 to 10.<br/>
        /// Default Value: 0.0
        /// </param>
        /// <param name="posYOff">
        /// Moves the avatar down, in half canvas heights. Supported range -10 to 10.<br/>
        /// Default Value: 0.0
        /// </param>
        /// <param name="posZOff">
        /// Metres the camera backs away from the avatar (negative moves in). Supported range -5 to 5.<br/>
        /// Default Value: 0.0
        /// </param>
        /// <param name="rotXOff">
        /// Degrees the camera tilts up (pitch). Supported range -180 to 180.<br/>
        /// Default Value: 0.0
        /// </param>
        /// <param name="rotYOff">
        /// Degrees the camera pans right (yaw). Supported range -180 to 180.<br/>
        /// Default Value: 0.0
        /// </param>
        /// <param name="rotZOff">
        /// Degrees the camera rolls clockwise. Supported range -180 to 180.<br/>
        /// Default Value: 0.0
        /// </param>
        /// <param name="zoom">
        /// Multiplies the avatar's zoom; 1 is no change. Supported range above 0, up to 4.<br/>
        /// Default Value: 1.0
        /// </param>
        /// <param name="orbitXOff">
        /// Degrees the camera orbits up over the avatar's head (elevation). Supported range -80 to 80.<br/>
        /// Default Value: 0.0
        /// </param>
        /// <param name="orbitYOff">
        /// Degrees the camera orbits round to its right (azimuth). Supported range -180 to 180.<br/>
        /// Default Value: 0.0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CameraSetting(
            double? posXOff,
            double? posYOff,
            double? posZOff,
            double? rotXOff,
            double? rotYOff,
            double? rotZOff,
            double? zoom,
            double? orbitXOff,
            double? orbitYOff)
        {
            this.PosXOff = posXOff;
            this.PosYOff = posYOff;
            this.PosZOff = posZOff;
            this.RotXOff = rotXOff;
            this.RotYOff = rotYOff;
            this.RotZOff = rotZOff;
            this.Zoom = zoom;
            this.OrbitXOff = orbitXOff;
            this.OrbitYOff = orbitYOff;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CameraSetting" /> class.
        /// </summary>
        public CameraSetting()
        {
        }

    }
}