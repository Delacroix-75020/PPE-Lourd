using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppelourd
{
    class User
    {
        public enum RoleType
        {
            EMPLOYE,
            ADMIN
        }

        private string username;
        public string Username
        {
            get
            {
                return username;
            }
        }

        private string email;
        public string Email
        {
            get
            {
                return email;
            }
        }

        private string password;
        public string Password
        {
            get
            {
                return password;
            }
        }
        private RoleType role;
        public RoleType Role
        {
            get
            {
                return role;
            }
        }

        public User (string username, string email, string password, RoleType role)
        {
            this.username = username;
            this.email = email;
            this.password = password;
            this.role = role;
        }

        public static int roleTypeToInt(RoleType role)
        {
            switch (role)
            {
                case RoleType.EMPLOYE:
                    return 0;

                case RoleType.ADMIN:
                    return 1;

                default:
                    return -1;
            }
        }

        public static RoleType intToRoleType (int role)
        {
            switch (role)
            {
                case 0:
                    return RoleType.EMPLOYE;

                case 1:
                    return RoleType.ADMIN;

                default:
                    throw new Exception("Unknown Role Type");

            }
        }
    }
}
