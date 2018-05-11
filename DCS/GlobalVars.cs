﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCS
{
    public class GlobalVars
    {
        //装弹指示灯的常量
        public const int AMMOLOAD_NOT_LOADED = 0;
        public const int AMMOLOAD_OPEN = 1;
        public const int AMMOLOAD_LOADED = 2;

        //各个指示灯的状态记录变量，bool型的true代表开，false代表关
        public static bool servoControlSwitchState = false;
        public static bool laserControlSwitchState = false;
        public static bool safeState = false;
        public static int ammoLoadState = AMMOLOAD_NOT_LOADED;

        //记录剩余弹量
        public static int ammoLeftNum = 200;
        //记录可装弹总数
        public static int ammoLoadNum = 200;
        //射弹计数
        public static int projectileCount = 0;
        //射弹数清零与否，每次发送数据时检测此项，为true则发送一次清零控制并重置成false
        public static bool projectileCountClear = false;

        //记录俯仰角度的mil值，记的是解析出来的数据，-1667~10000，1LSB=0.1mil
        public static int pitchAngle = 0;
        //俯仰角度清零与否，每次发送数据时检测此项，为true则发送一次清零控制并重置成false
        public static bool pitchAngleClear = false;

        //记录方位位置值的mil值，记的是解析出来的数据，0~59999，1LSB=0.1mil
        public static int dialPlateAngle = 0;
        //方位位置值清零与否，每次发送数据时检测此项，为true则发送一次清零控制并重置成false
        public static bool dialPlateAngleClear = false;

        //焦距状态，倍数1-20
        public static int focalDistanceMultiple = 1;

        //记录一个焦距挡位的瞄准分划的位置和大小信息
        public struct AimingReticleConfigParameter
        {
            public int posX;//位置的x坐标
            public int posY;//位置的y坐标
            public int sizePercent;//瞄准分划的大小百分比，-100~100

            public AimingReticleConfigParameter(int x,int y,int percent)
            {
                posX = x;
                posY = y;
                sizePercent = percent;
            }
        }
        //二十个焦距档位的参数记录
        public static AimingReticleConfigParameter[] aimingReticleConfigs = new AimingReticleConfigParameter[20];

        //摄像机ip地址
        public static string cameraIP;
        //摄像机rtsp流端口
        public static string cameraPort;
        //摄像机登陆用户名
        public static string userName;
        //摄像机登陆用户密码
        public static string userPassword;
        //摄像机串流地址
        public static string cameraRTSPPath;

    }
}