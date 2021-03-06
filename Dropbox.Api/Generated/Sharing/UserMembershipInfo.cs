// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Sharing
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The information about a user member of the shared content.</para>
    /// </summary>
    /// <seealso cref="Dropbox.Api.Sharing.MembershipInfo" />
    public class UserMembershipInfo : MembershipInfo
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<UserMembershipInfo> Encoder = new UserMembershipInfoEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<UserMembershipInfo> Decoder = new UserMembershipInfoDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UserMembershipInfo" />
        /// class.</para>
        /// </summary>
        /// <param name="accessType">The access type for this member.</param>
        /// <param name="user">The account information for the membership user.</param>
        /// <param name="permissions">The permissions that requesting user has on this member.
        /// The set of permissions corresponds to the MemberActions in the request.</param>
        /// <param name="initials">Suggested name initials for a member.</param>
        /// <param name="isInherited">True if the member has access from a parent
        /// folder.</param>
        public UserMembershipInfo(AccessLevel accessType,
                                  UserInfo user,
                                  col.IEnumerable<MemberPermission> permissions = null,
                                  string initials = null,
                                  bool isInherited = false)
            : base(accessType, permissions, initials, isInherited)
        {
            if (user == null)
            {
                throw new sys.ArgumentNullException("user");
            }

            this.User = user;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UserMembershipInfo" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public UserMembershipInfo()
        {
        }

        /// <summary>
        /// <para>The account information for the membership user.</para>
        /// </summary>
        public UserInfo User { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="UserMembershipInfo" />.</para>
        /// </summary>
        private class UserMembershipInfoEncoder : enc.StructEncoder<UserMembershipInfo>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(UserMembershipInfo value, enc.IJsonWriter writer)
            {
                WriteProperty("access_type", value.AccessType, writer, Dropbox.Api.Sharing.AccessLevel.Encoder);
                WriteProperty("user", value.User, writer, Dropbox.Api.Sharing.UserInfo.Encoder);
                if (value.Permissions.Count > 0)
                {
                    WriteListProperty("permissions", value.Permissions, writer, Dropbox.Api.Sharing.MemberPermission.Encoder);
                }
                if (value.Initials != null)
                {
                    WriteProperty("initials", value.Initials, writer, enc.StringEncoder.Instance);
                }
                WriteProperty("is_inherited", value.IsInherited, writer, enc.BooleanEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="UserMembershipInfo" />.</para>
        /// </summary>
        private class UserMembershipInfoDecoder : enc.StructDecoder<UserMembershipInfo>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="UserMembershipInfo" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override UserMembershipInfo Create()
            {
                return new UserMembershipInfo();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(UserMembershipInfo value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "access_type":
                        value.AccessType = Dropbox.Api.Sharing.AccessLevel.Decoder.Decode(reader);
                        break;
                    case "user":
                        value.User = Dropbox.Api.Sharing.UserInfo.Decoder.Decode(reader);
                        break;
                    case "permissions":
                        value.Permissions = ReadList<MemberPermission>(reader, Dropbox.Api.Sharing.MemberPermission.Decoder);
                        break;
                    case "initials":
                        value.Initials = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "is_inherited":
                        value.IsInherited = enc.BooleanDecoder.Instance.Decode(reader);
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
