namespace internship_api.Models.user.model
{
    public class UserModel
    {
        public virtual string? UserId { get; set; }
        public virtual string? Name { get; set; }
        public virtual string? LastName { get; set; }
        public virtual DateTime? CreatedDate { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }

        public void SetUser(User user)
        {
            this.UserId = user.Id;
            this.Name = user.Name;
            this.LastName = user.LastName;
            this.CreatedDate = user.CreatedDate;
            this.ModifiedDate = user.ModifiedDate;
        }
    }
}