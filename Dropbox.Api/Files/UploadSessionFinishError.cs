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
    /// <para>Errors for <see
    /// cref="Dropbox.Api.Files.Routes.FilesRoutes.UploadSessionFinishAsync" />.</para>
    /// </summary>
    public class UploadSessionFinishError : enc.IEncodable<UploadSessionFinishError>
    {
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UploadSessionFinishError" />
        /// class.</para>
        /// </summary>
        public UploadSessionFinishError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is LookupFailed</para>
        /// </summary>
        public bool IsLookupFailed
        {
            get
            {
                return this is LookupFailed;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a LookupFailed, or <c>null</c>.</para>
        /// </summary>
        public LookupFailed AsLookupFailed
        {
            get
            {
                return this as LookupFailed;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is CommitFailed</para>
        /// </summary>
        public bool IsCommitFailed
        {
            get
            {
                return this is CommitFailed;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a CommitFailed, or <c>null</c>.</para>
        /// </summary>
        public CommitFailed AsCommitFailed
        {
            get
            {
                return this as CommitFailed;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region IEncodable<UploadSessionFinishError> methods

        /// <summary>
        /// <para>Encodes the object using the supplied encoder.</para>
        /// </summary>
        /// <param name="encoder">The encoder being used to serialize the object.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void enc.IEncodable<UploadSessionFinishError>.Encode(enc.IEncoder encoder)
        {
            if (this.IsLookupFailed)
            {
                ((enc.IEncodable<LookupFailed>)this).Encode(encoder);
            }
            else if (this.IsCommitFailed)
            {
                ((enc.IEncodable<CommitFailed>)this).Encode(encoder);
            }
            else
            {
                ((enc.IEncodable<Other>)this).Encode(encoder);
            }
        }

        /// <summary>
        /// <para>Decodes on object using the supplied decoder.</para>
        /// </summary>
        /// <param name="decoder">The decoder used to deserialize the object.</param>
        /// <returns>The deserialized object. Note: this is not necessarily the current
        /// instance.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        UploadSessionFinishError enc.IEncodable<UploadSessionFinishError>.Decode(enc.IDecoder decoder)
        {
            switch (decoder.GetUnionName())
            {
            case "lookup_failed":
                using (var obj = decoder.GetObject())
                {
                    return new LookupFailed(obj.GetFieldObject<UploadSessionLookupError>("lookup_failed"));
                }
            case "commit_failed":
                using (var obj = decoder.GetObject())
                {
                    return new CommitFailed(obj.GetFieldObject<CommitError>("commit_failed"));
                }
            default:
                return Other.Instance;
            }
        }

        #endregion

        /// <summary>
        /// <para>The session arguments are incorrect; the value explains the reason.</para>
        /// </summary>
        public sealed class LookupFailed : UploadSessionFinishError, enc.IEncodable<LookupFailed>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="LookupFailed" />
            /// class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public LookupFailed(UploadSessionLookupError value)
            {
                this.Value = value;
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public UploadSessionLookupError Value { get; private set; }

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            void enc.IEncodable<LookupFailed>.Encode(enc.IEncoder encoder)
            {
                using (var obj = encoder.AddObject())
                {
                    obj.AddField("lookup_failed", this.Value);
                }
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            LookupFailed enc.IEncodable<LookupFailed>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }

        /// <summary>
        /// <para>The commit failed; the value explains the reason.</para>
        /// </summary>
        public sealed class CommitFailed : UploadSessionFinishError, enc.IEncodable<CommitFailed>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="CommitFailed" />
            /// class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public CommitFailed(CommitError value)
            {
                this.Value = value;
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public CommitError Value { get; private set; }

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            void enc.IEncodable<CommitFailed>.Encode(enc.IEncoder encoder)
            {
                using (var obj = encoder.AddObject())
                {
                    obj.AddField("commit_failed", this.Value);
                }
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            CommitFailed enc.IEncodable<CommitFailed>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }

        /// <summary>
        /// <para>An unspecified error.</para>
        /// </summary>
        public sealed class Other : UploadSessionFinishError, enc.IEncodable<Other>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            void enc.IEncodable<Other>.Encode(enc.IEncoder encoder)
            {
                encoder.AddUnion("other");
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            Other enc.IEncodable<Other>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }
    }
}
