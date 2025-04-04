window.userLinkedin = {
    init: function () {
        this.bindEvents();
    }
    , bindEvents: function () {
        var self = this;
        $('#btnLinkedin').on('click', function () {
            self.login();
        });
    }
    , login: function () {
        var self = this;
        var url = '/user/loginLinkedin';
        $.ajax({
            url: url,
            type: 'GET',
            dataType: 'json',
            success: function (data) {
                if (data && data.url) {
                    window.location.href = data.url;
                }
            },
            error: function (xhr, status, error) {
                console.error('Error during LinkedIn login:', error);
            }
        });
    }
    , logout: function () {
        var self = this;
        var url = '/user/logoutLinkedin';
        $.ajax({
            url: url,
            type: 'GET',
            dataType: 'json',
            success: function (data) {
                if (data && data.success) {
                    window.location.reload();
                }
            },
            error: function (xhr, status, error) {
                console.error('Error during LinkedIn logout:', error);
            }
        });
    }
    , updateProfile: function () {
        var self = this;
        var url = '/user/updateLinkedinProfile';
        $.ajax({
            url: url,
            type: 'POST',
            dataType: 'json',
            success: function (data) {
                if (data && data.success) {
                    alert('Profile updated successfully');
                }
            },
            error: function (xhr, status, error) {
                console.error('Error during LinkedIn profile update:', error);
            }
        });
    }
    , getProfile: function () {
        var self = this;
        var url = '/user/getLinkedinProfile';
        $.ajax({
            url: url,
            type: 'GET',
            dataType: 'json',
            success: function (data) {
                if (data && data.profile) {
                    console.log('LinkedIn Profile:', data.profile);
                }
            },
            error: function (xhr, status, error) {
                console.error('Error fetching LinkedIn profile:', error);
            }
        });
    }
};