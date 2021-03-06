// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Unlinked app for member.</para>
    /// </summary>
    public class AppUnlinkUserDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<AppUnlinkUserDetails> Encoder = new AppUnlinkUserDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<AppUnlinkUserDetails> Decoder = new AppUnlinkUserDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="AppUnlinkUserDetails" />
        /// class.</para>
        /// </summary>
        /// <param name="appInfo">Relevant application details.</param>
        public AppUnlinkUserDetails(AppLogInfo appInfo)
        {
            if (appInfo == null)
            {
                throw new sys.ArgumentNullException("appInfo");
            }

            this.AppInfo = appInfo;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="AppUnlinkUserDetails" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public AppUnlinkUserDetails()
        {
        }

        /// <summary>
        /// <para>Relevant application details.</para>
        /// </summary>
        public AppLogInfo AppInfo { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="AppUnlinkUserDetails" />.</para>
        /// </summary>
        private class AppUnlinkUserDetailsEncoder : enc.StructEncoder<AppUnlinkUserDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(AppUnlinkUserDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("app_info", value.AppInfo, writer, global::Dropbox.Api.TeamLog.AppLogInfo.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="AppUnlinkUserDetails" />.</para>
        /// </summary>
        private class AppUnlinkUserDetailsDecoder : enc.StructDecoder<AppUnlinkUserDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="AppUnlinkUserDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override AppUnlinkUserDetails Create()
            {
                return new AppUnlinkUserDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(AppUnlinkUserDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "app_info":
                        value.AppInfo = global::Dropbox.Api.TeamLog.AppLogInfo.Decoder.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
