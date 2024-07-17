mergeInto(LibraryManager.library, {
ShowAdv: function(){
ysdk.adv.showFullscreenAdv({
    callbacks: {
        onClose: function(wasShown) {
          SendMessage('Game','UnPause');
        },
        onError: function(error) {
          SendMessage('Game','UnPause');
        },
        onOpen: function(){
          SendMessage('Game','Pause');
        }
    }
})
},

ShowRewardedForUnlock : function(){
    ysdk.adv.showRewardedVideo({
    callbacks: {
        onOpen: () => {
          SendMessage('Game','OnPause');
        },
        onRewarded: () => {
          SendMessage('Main Camera','Unlock');
        },
        onClose: () => {
          SendMessage('Game','UnPause');
        }, 
        onError: (e) => {
          console.log('Error while open video ad:', e);
        }
    }
})
},
ShowRewardedForMoney : function(){
    ysdk.adv.showRewardedVideo({
    callbacks: {
        onOpen: () => {
          SendMessage('MoveMoney','ClaimReward');
          SendMessage('Game','OnPause');
        },
        onRewarded: () => {
          SendMessage('player','MoneyForAd');
          SendMessage('Game','UnPause');
        },
        onClose: () => {
          SendMessage('Game','UnPause');
        }, 
        onError: (e) => {
          SendMessage('Game','UnPause');
        }
    }
})
},

    IsMobile: function () {
        var ua = window.navigator.userAgent.toLowerCase();
        var mobilePattern = /android|iphone|ipad|ipod/i;

        return ua.search(mobilePattern) !== -1 || (ua.indexOf("macintosh") !== -1 && "ontouchend" in document);
    },
}); 
