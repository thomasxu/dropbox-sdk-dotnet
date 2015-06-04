// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>Errors from <see cref="Dropbox.Api.Files.Routes.FilesRoutes.DownloadAsync" />
    /// when the file cannot be downloaded.</para>
    /// </summary>
    public class NoFileReason : enc.IEncodable<NoFileReason>
    {
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="NoFileReason" /> class.</para>
        /// </summary>
        public NoFileReason()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is NotFound</para>
        /// </summary>
        public bool IsNotFound
        {
            get
            {
                return this is NotFound;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a NotFound, or <c>null</c>.</para>
        /// </summary>
        public NotFound AsNotFound
        {
            get
            {
                return this as NotFound;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is IsFolder</para>
        /// </summary>
        public bool IsIsFolder
        {
            get
            {
                return this is IsFolder;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a IsFolder, or <c>null</c>.</para>
        /// </summary>
        public IsFolder AsIsFolder
        {
            get
            {
                return this as IsFolder;
            }
        }

        #region IEncodable<NoFileReason> methods

        /// <summary>
        /// <para>Encodes the object using the supplied encoder.</para>
        /// </summary>
        /// <param name="encoder">The encoder being used to serialize the object.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void enc.IEncodable<NoFileReason>.Encode(enc.IEncoder encoder)
        {
            if (this.IsNotFound)
            {
                ((enc.IEncodable<NotFound>)this).Encode(encoder);
            }
            else if (this.IsIsFolder)
            {
                ((enc.IEncodable<IsFolder>)this).Encode(encoder);
            }
            else
            {
                throw new sys.InvalidOperationException();
            }
        }

        /// <summary>
        /// <para>Decodes on object using the supplied decoder.</para>
        /// </summary>
        /// <param name="decoder">The decoder used to deserialize the object.</param>
        /// <returns>The deserialized object. Note: this is not necessarily the current
        /// instance.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        NoFileReason enc.IEncodable<NoFileReason>.Decode(enc.IDecoder decoder)
        {
            switch (decoder.GetUnionName())
            {
            case "not_found":
                return NotFound.Instance;
            case "is_folder":
                return IsFolder.Instance;
            default:
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        /// <summary>
        /// <para>The path is not found.</para>
        /// </summary>
        public sealed class NotFound : NoFileReason, enc.IEncodable<NotFound>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="NotFound" /> class.</para>
            /// </summary>
            private NotFound()
            {
            }

            /// <summary>
            /// <para>A singleton instance of NotFound</para>
            /// </summary>
            public static readonly NotFound Instance = new NotFound();

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            void enc.IEncodable<NotFound>.Encode(enc.IEncoder encoder)
            {
                encoder.AddUnion("not_found");
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            NotFound enc.IEncodable<NotFound>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }

        /// <summary>
        /// <para>The path refers to a folder. Only files can be downloaded.</para>
        /// </summary>
        public sealed class IsFolder : NoFileReason, enc.IEncodable<IsFolder>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="IsFolder" /> class.</para>
            /// </summary>
            private IsFolder()
            {
            }

            /// <summary>
            /// <para>A singleton instance of IsFolder</para>
            /// </summary>
            public static readonly IsFolder Instance = new IsFolder();

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            void enc.IEncodable<IsFolder>.Encode(enc.IEncoder encoder)
            {
                encoder.AddUnion("is_folder");
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            IsFolder enc.IEncodable<IsFolder>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }
    }
}
