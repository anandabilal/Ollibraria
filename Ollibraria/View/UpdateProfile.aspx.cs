using Ollibraria.Controller;
using Ollibraria.Handler;
using Ollibraria.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ollibraria.View
{
    public partial class UpdateProfile : System.Web.UI.Page
    {
        User GetUserFromSession()
        {
            User findUser;
            if (Session["user"] == null)
            {
                var id = Request.Cookies["user_cookie"].Value;
                findUser = UserHandler.FindById(id);

                Session["user"] = findUser;
            }
            else
            {
                findUser = (User)Session["user"];
            }
            return findUser;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["user"] == null && Request.Cookies["user_cookie"] == null)
                {
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    User user = GetUserFromSession();
                    User updatedUser = UserHandler.FindById(user.UserId);

                    if (user != updatedUser)
                    {
                        user = updatedUser;
                    }

                    txtName.Text = user.Name.ToString();
                    if (user.Gender == "Male")
                    {
                        radioMale.Checked = true;
                    }
                    else
                    {
                        radioFemale.Checked = true;
                    }
                    txtPhone.Text = user.PhoneNumber.ToString();
                    txtAddress.Text = user.Address.ToString();
                }
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            lblError.ForeColor = System.Drawing.Color.Red;
            lblError.Text = "";

            String updateName = txtName.Text.ToString();
            String updateGender = "";
            bool genderChecked = true;
            if (radioMale.Checked)
            {
                updateGender = radioMale.Text.ToString();
            }
            else if (radioFemale.Checked)
            {
                updateGender = radioFemale.Text.ToString();
            }
            else
            {
                genderChecked = false;
            }
            String updatePhone = txtPhone.Text.ToString();
            String updateAddress = txtAddress.Text.ToString();

            lblError.Text = ControllerValidation.UpdateProfile(updateName, genderChecked, updatePhone, updateAddress);
            if (lblError.Text.Equals(""))
            {
                User temp = GetUserFromSession();
                User updateUser = UserHandler.FindById(temp.UserId);

                UserHandler.updateUser(updateUser, updateName, updateGender, updatePhone, updateAddress);

                lblError.ForeColor = System.Drawing.Color.Green;
                lblError.Text = "Profile has been updated successfully!";
            }
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}