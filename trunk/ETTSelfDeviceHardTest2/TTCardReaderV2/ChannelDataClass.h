#pragma once



class ChannelDataClass
{
private:
public:
	ChannelDataClass(void);
	~ChannelDataClass(void);
	bool SetData(unsigned char nChannelFlg, char *pData);
	unsigned int GetChannelIDS(unsigned char nChannelFlg);
	unsigned char GetChannelDataBeginFlg(unsigned int nChannel);
	bool GetChannelData(unsigned char nChannel,unsigned int& nlength,char *pData);
private:
};