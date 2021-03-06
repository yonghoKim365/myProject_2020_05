package drawer;

import java.awt.AlphaComposite;
import java.awt.FontMetrics;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.Image;
import java.awt.image.ImageObserver;

import org.dvb.ui.DVBAlphaComposite;
import org.dvb.ui.DVBGraphics;
import org.dvb.ui.UnsupportedDrawingOperationException;

import com.dreamer.x2let.util.ImageUtil;


public class Drawer
{

	public ImageObserver observer;
	
	public int logicalScreenH = 1080; 
	public int realScreenH = 1080;
	public int scrRate = 1000; // 1000 = 100
	public final int scrMappingVal = 1000; // ȭ������ �� ��ǥ��� ����,  
	// ȭ������ ��� ��ǥ�� ����Ҷ����� ������ ��ǥ * scrRate / scrZoomVal = ���ο� ��ǥ
	// 1080 �϶��� ��ǥ 100 = 720 �϶��� 66 ��. =>  100 * 666 / 1000 = 66;
	
	public void setScreenMapping(int logicalHSize, int realHSize){
		logicalScreenH = logicalHSize;
		realScreenH = realHSize;
		
		scrRate = realScreenH * scrMappingVal / logicalScreenH;
	}
	
	public int getMapping(int v){
		if (scrRate == 1000)return v;
		
		return v * scrRate / scrMappingVal;
	}

	public void setAlpha(Graphics g, int alphaData)
    {

		  if (alphaData<=0)return;

          //100 -> ������
          try
          {
                 float fAlpha = alphaData /(float)100;

                 if (g instanceof DVBGraphics) {
                        ((DVBGraphics) g).setDVBComposite(DVBAlphaComposite.getInstance(DVBAlphaComposite.SRC_OVER, fAlpha));
                 } else {
                        ((Graphics2D) g).setComposite(AlphaComposite.getInstance(AlphaComposite.SRC_OVER, fAlpha));
                 }
          }

          catch (UnsupportedDrawingOperationException e)
          {
                 e.printStackTrace();
          }

          catch(Exception e)
          {
                 e.printStackTrace();
          }
    }


	/*
	public void setAlpha(Graphics g, int alphaVal){

		//#ifdef __USE_EMUL
		if (true)return;
		//#endif

		//#ifdef __NO_ALPHA_EFFECT
		//# if (true)return;
		//#endif

		if (alphaVal<=0)return; // perfect trans,
		if (alphaVal>100)alphaVal=100;

		DVBGraphics dvbg = (DVBGraphics) g;

		// ���� ���
		float fAlpha = alphaVal /(float)100;     // alpha ��  0���� 10����

		//DEBUGF("fAlpha="+fAlpha);

		try {
			dvbg.setDVBComposite(DVBAlphaComposite.getInstance(DVBAlphaComposite.SRC_OVER, fAlpha));
		} catch (UnsupportedDrawingOperationException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	*/


	public void setImageObserver(ImageObserver io){
		observer = io;
	}

	public Image getImage(String path){
		return ImageUtil.getImage("image/"+path+".png");
	}
	
	public void clearRect(Graphics g, int a,int b,int c,int d){
		g.clearRect(getMapping(a),getMapping(b),getMapping(c),getMapping(d));
	}
	public void drawRect(Graphics g, int a,int b,int c,int d){
		g.drawRect(getMapping(a),getMapping(b),getMapping(c),getMapping(d));
	}
	
	public void drawImage(Graphics _gr, String img, int x, int y){
		_gr.drawImage(getImage(img), getMapping(x), getMapping(y),observer);
	}
	
	public void drawImage(Graphics _gr, String _fileName, int x, int y, int w, int h, ImageObserver io ){
		_gr.drawImage(getImage(_fileName), getMapping(x), getMapping(y), getMapping(w), getMapping(h), io);//arg3);
	}
	
	public void drawImage(Graphics _gr, Image img, int x, int y, int w, int h, ImageObserver io){
		_gr.drawImage(img, getMapping(x), getMapping(y), getMapping(w), getMapping(h), io);
	}
	
	public void drawImage(Graphics _gr, Image img, int x, int y, int w, int h){
		_gr.drawImage(img, getMapping(x), getMapping(y), getMapping(w), getMapping(h), observer);//arg3);
	}
	
	public void drawImage(Graphics _gr, String _fileName, int x, int y, int w, int h){
		_gr.drawImage(getImage(_fileName), getMapping(x), getMapping(y), getMapping(w), getMapping(h), observer);//arg3);
	}

	public void drawImageZoom(Graphics _gr, String img, int x, int y, int zoomRate){ // zoomRate == 0 ~ 1000
		Image image = getImage(img);
		int w = image.getWidth(observer);
		int h = image.getHeight(observer);
		w = zoomRate * w / 1000;
		h = zoomRate * h / 1000;
		_gr.drawImage(image, getMapping(x), getMapping(y), w, h, observer);
	}

	public void drawImage(Graphics _gr, Image img, int x, int y){
		_gr.drawImage(img, getMapping(x), getMapping(y), observer);//arg3);
	}
	
	

	public void drawImage2X(Graphics _gr, String _fileName, int x, int y){
		Image img =  getImage(_fileName);
		
		_gr.drawImage(img, getMapping(x), getMapping(y), img.getWidth(observer)*2,img.getHeight(observer)*2, observer);
	}
	
	public void drawImage2X(Graphics _gr, Image img, int x, int y){
		_gr.drawImage(img, getMapping(x), getMapping(y), img.getWidth(observer)*2,img.getHeight(observer)*2,observer);
	}

	/*
	 * 1/2 ����� �׸�
	 */
	public void drawImage2UX(Graphics _gr, String _fileName, int x, int y){
		Image img =  getImage(_fileName);
		//drawImage(_gr, img, getMapping(x), getMapping(y), img.getWidth(observer)/2,img.getHeight(observer)/2);
		_gr.drawImage(img, getMapping(x), getMapping(y), img.getWidth(observer)/2,img.getHeight(observer)/2,observer);
	}

	public void drawImageCC(Graphics _gr, String _fileName, int x, int y){
		Image img =  getImage(_fileName);
		//drawImage(_gr, img, getMapping(x)-img.getWidth(observer)/2, getMapping(y)-img.getHeight(observer)/2, observer);
		_gr.drawImage( img, getMapping(x)-img.getWidth(observer)/2, getMapping(y)-img.getHeight(observer)/2, observer);
	}

	public void drawImage(Graphics _gr, Image img, int x, int y, java.awt.image.ImageObserver arg3){
		_gr.drawImage(img, getMapping(x), getMapping(y), arg3);
	}

	public void drawClipImage(Graphics g, String img, int x, int y, int clip_x, int clip_y, int clip_w, int clip_h){
		//g.drawImage(getImage(img), getMapping(x), getMapping(y), x + clip_w, y + clip_h, clip_x, clip_y, clip_x+clip_w, clip_y + clip_h, observer);
		g.drawImage(getImage(img), getMapping(x), getMapping(y), getMapping(x) + getMapping(clip_w), getMapping(y) + getMapping(clip_h), getMapping(clip_x), getMapping(clip_y), getMapping(clip_x)+getMapping(clip_w), getMapping(clip_y) + getMapping(clip_h),observer);
	}
	
	public void drawClipImage(Graphics g, String img, int x, int y, int clip_x, int clip_y, int clip_w, int clip_h, ImageObserver io){
		//g.drawImage(getImage(img), getMapping(x), getMapping(y), x + clip_w, y + clip_h, clip_x, clip_y, clip_x+clip_w, clip_y + clip_h, io);
		g.drawImage(getImage(img), getMapping(x), getMapping(y), getMapping(x) + getMapping(clip_w), getMapping(y) + getMapping(clip_h), getMapping(clip_x), getMapping(clip_y), getMapping(clip_x)+getMapping(clip_w), getMapping(clip_y) + getMapping(clip_h), io);
	}

	public void drawClipImage(Graphics g, Image img, int x, int y, int clip_x, int clip_y, int clip_w, int clip_h){
		//g.drawImage(img, getMapping(x), getMapping(y), x + clip_w, y + clip_h, clip_x, clip_y, clip_x+clip_w, clip_y + clip_h, observer);
		g.drawImage(img, getMapping(x), getMapping(y), getMapping(x) + getMapping(clip_w), getMapping(y) + getMapping(clip_h), getMapping(clip_x), getMapping(clip_y), getMapping(clip_x)+getMapping(clip_w), getMapping(clip_y) + getMapping(clip_h), observer);
	}
	
	public void drawClipImage(Graphics g, Image img, int x, int y, int clip_x, int clip_y, int clip_w, int clip_h, ImageObserver io){
		//g.drawImage(img, getMapping(x), getMapping(y), x + clip_w, y + clip_h, clip_x, clip_y, clip_x+clip_w, clip_y + clip_h, io);
		g.drawImage(img, getMapping(x), getMapping(y), getMapping(x) + getMapping(clip_w), getMapping(y) + getMapping(clip_h), getMapping(clip_x), getMapping(clip_y), getMapping(clip_x)+getMapping(clip_w), getMapping(clip_y) + getMapping(clip_h), io);
	}

	public void drawImage(Graphics g, Image img, int x, int y, int w, int h, int clip_x, int clip_y, int clip_w, int clip_h){
		//g.drawImage(img, getMapping(x), getMapping(y), x + w, y + h, clip_x, clip_y, clip_x+clip_w, clip_y + clip_h, observer);
		
		g.drawImage(img, getMapping(x), getMapping(y), getMapping(x) + getMapping(w), getMapping(y) + getMapping(h), getMapping(clip_x), getMapping(clip_y), getMapping(clip_x)+getMapping(clip_w), getMapping(clip_y) + getMapping(clip_h), observer);
	}

	public void drawImage(Graphics g, String img, int x, int y, int w, int h, int clip_x, int clip_y, int clip_w, int clip_h){
		//g.drawImage(getImage(img), getMapping(x), getMapping(y), x+w, y+h, clip_x, clip_y, clip_x+clip_w, clip_y + clip_h, observer);
		g.drawImage(getImage(img), getMapping(x), getMapping(y), getMapping(x) + getMapping(w), getMapping(y) + getMapping(h), getMapping(clip_x), getMapping(clip_y), getMapping(clip_x)+getMapping(clip_w), getMapping(clip_y) + getMapping(clip_h), observer);
	}

	public void drawImageCC(Graphics _gr, String _fileName, int x, int y, int draw_w, int draw_h, boolean bMirror){
		Image _img = getImage(_fileName);
		int imgW = _img.getWidth(null);
		int imgH = _img.getHeight(null);

		/*if (bMirror){
			_gr.drawImage(_img, getMapping(x) + draw_w-(draw_w/2), getMapping(y)-(draw_h/2), x-(draw_w/2), y + draw_h-(draw_h/2), 0, 0, imgW, imgH, observer);
		}
		else{
			_gr.drawImage(_img, getMapping(x)-(draw_w/2), getMapping(y)-(draw_h/2), x + draw_w-(draw_w/2), y + draw_h-(draw_h/2), 0, 0, imgW, imgH, observer);
		}*/
		if (bMirror){
			_gr.drawImage(_img, getMapping(x) + getMapping(draw_w)-(getMapping(draw_w)/2), getMapping(y)-(getMapping(draw_h)/2), getMapping(x)-(getMapping(draw_w)/2), getMapping(y) + getMapping(draw_h)-(getMapping(draw_h)/2), 0, 0, getMapping(imgW), getMapping(imgH), observer);
		}
		else{
			_gr.drawImage(_img, getMapping(x)-(getMapping(draw_w)/2), getMapping(y)-(getMapping(draw_h)/2), getMapping(x) + getMapping(draw_w)-(getMapping(draw_w)/2), y + getMapping(draw_h)-(getMapping(draw_h)/2), 0, 0, getMapping(imgW), getMapping(imgH), observer);
		}
	}
	
	public void drawImage(Graphics _gr, String _fileName, int x, int y, ImageObserver io){
		_gr.drawImage( getImage(_fileName), getMapping(x), getMapping(y), io);
	}
/*
	public final int FLIP_H = 0x01; // �����ø� - �¿찡 �ٲ��.
	public final int FLIP_V = 0x02; // �����ø� - ���ϰ� �ٲ��.

	public void drawImage(Graphics _gr, String _fileName, int x, int y, int _flip){

		Image _img = getImage(_fileName);
		int w = _img.getWidth(null);
		int h = _img.getHeight(null);

		int dx1 = x;
		int dy1 = y;
		int dx2 = x + w;
		int dy2 = y + h;
		int sx1 = 0;
		int sy1 = 0;
		int sx2 = w;
		int sy2 = h;

		boolean _Hflip = false;
		boolean _Vflip = false;
		if ((_flip & FLIP_H) == 1)_Hflip=true;
		if (((_flip & FLIP_V) >> 1)==1)_Vflip=true;

		if (_Hflip){
			sx1 = w;
			sx2 = 0;
		}
		if (_Vflip){
			sy1 = h;
			sy2 = 0;
		}

		_gr.drawImage(_img, dx1,dy1,dx2,dy2,sx1,sy1,sx2,sy2,observer);

	}
*/
	/**
	 * ������ �ڸ��� ���ϱ�
	 */
	public int getJarisu(int num){
		for (int i =1;i<10;i++){
			double t = Math.pow(10, i);
			//System.out.println(" i ="+i+",pow="+t);
			if (num < t)return i;
		}
		return 10;
	}


	public void drawNumber(Graphics g, String img, int x, int y, int num, int font_w, int font_h, int space){
		int width_per_number = font_w;//44;//29;//32;
		int height_per_number = font_h;//50;//44;//41;
		int space_per_number = space;//-5;//1;//6;//-2;//0;//2;

		x -= width_per_number;

		int jarisu = getJarisu(num);

		int n = 0;
		for(int i=0;i<jarisu;i++){
			if (i==0){
				n = num%10;
			}
			else{
				// i == 1 : 2��° (10����)�ڸ�
				// i == 2 : 3��° (100����)�ڸ�

				int a = (int)Math.pow(10,i+1);
				int b = (int)Math.pow(10,i);

				n = (num%a)/b;
			}

			drawClipImage(g, img, x, y, width_per_number*n, 0, width_per_number, height_per_number);

			x -= (width_per_number + space_per_number);
		}
	}

	/**
	 * ���ڸ� �׸���. �ڸ����� ������ ������ ���� ��ġ �������� ��´�.(Right-Top ����)
	 * @param g
	 * @param img
	 * @param x ���ڸ� ��� ��ġ. ������ ������ ������ �� ��ġ
	 * @param y ���ڸ� ��� ��ġ. ������ ������ Top  ��ġ
	 * @param num �׸� ����
	 * @param font_w
	 * @param font_h
	 * @param space �ڰ�
	 */
	public void drawNumberRT(Graphics g, String img, int x, int y, int num, int font_w, int font_h, int space){
		int width_per_number = font_w;//44;//29;//32;
		int height_per_number = font_h;//50;//44;//41;
		int space_per_number = space;//-5;//1;//6;//-2;//0;//2;

		x -= width_per_number;

		int jarisu = getJarisu(num);

		int n = 0;
		for(int i=0;i<jarisu;i++){
			if (i==0){
				n = num%10;
			}
			else{
				// i == 1 : 2��° (10����)�ڸ�
				// i == 2 : 3��° (100����)�ڸ�

				int a = (int)Math.pow(10,i+1);
				int b = (int)Math.pow(10,i);

				n = (num%a)/b;
			}

			drawClipImage(g, img, x, y, width_per_number*n, 0, width_per_number, height_per_number);

			x -= (width_per_number + space_per_number);
		}
	}

	public void drawNumberLT(Graphics g, String img, int x, int y, int num, int font_w, int font_h, int space){
		int width_per_number = font_w;//44;//29;//32;
		int height_per_number = font_h;//50;//44;//41;
		int space_per_number = space;//-5;//1;//6;//-2;//0;//2;

		int jarisu = getJarisu(num)-1;

		//DEBUGF("jarisu="+jarisu);

		int n = 0;
		for(int i=jarisu;i>=0;i--){
			if (i==0){
				n = num%10;
			}
			else{
				// i == 1 : 2��° (10����)�ڸ�
				// i == 2 : 3��° (100����)�ڸ�

				int a = (int)Math.pow(10,i+1);
				int b = (int)Math.pow(10,i);

				n = (num%a)/b;
			}

			//DEBUGF("i="+i+",n="+n);

			drawClipImage(g, img, x, y, width_per_number*n, 0, width_per_number, height_per_number);

			x += (width_per_number + space_per_number);
		}
	}
	
	public void drawStringLB(Graphics g, String str, int x, int y){
		//FontMetrics fm = g.getFontMetrics();
		//int w = fm.stringWidth(str);
		//int h = fm.getHeight();
		g.drawString(str,getMapping(x), getMapping(y));
	}
	
	public void drawStringLT(Graphics g, String str, int x, int y){
		if (str ==null)return;
		
		FontMetrics fm = g.getFontMetrics();
		//int w = fm.stringWidth(str);
		//int h = fm.getHeight();
		int h = fm.getAscent() - fm.getDescent() - fm.getLeading();
		g.drawString(str, getMapping(x), getMapping(y)+h);
	}
	
	public int getStrWidth(Graphics g, String str){
		FontMetrics fm = g.getFontMetrics();
		return fm.stringWidth(str);
	}
	
	public int getStrHeight(Graphics g, String str){
		FontMetrics fm = g.getFontMetrics();
		int h = fm.getAscent() - fm.getDescent() - fm.getLeading();
		return h;//fm.getHeight();
	}
	
	public void drawStringCC(Graphics g, String str, int x, int y){
		
		//g.setFont(new Font("Arial", Font.BOLD, 24));
		//g.setColor(Color.white);
		
		FontMetrics fm = g.getFontMetrics();
		int w = fm.stringWidth(str);
		int h = fm.getAscent() - fm.getDescent() - fm.getLeading();
		
		g.drawString(str, getMapping(x) - w/2, getMapping(y) + h/2);
	}
	
	public void drawStringCB(Graphics g, String str, int x, int y){
		
		//g.setFont(new Font("Arial", Font.BOLD, 24));
		//g.setColor(Color.white);
		
		FontMetrics fm = g.getFontMetrics();
		int w = fm.stringWidth(str);
		
		g.drawString(str, getMapping(x) - w/2, getMapping(y));
	}
	
	public void drawStringRT(Graphics g, String str, int x, int y){
		
		//g.setFont(new Font("Arial", Font.BOLD, 24));
		//g.setColor(Color.white);
		
		FontMetrics fm = g.getFontMetrics();
		int w = fm.stringWidth(str);
		int h = fm.getAscent() - fm.getDescent() - fm.getLeading();
		g.drawString(str, getMapping(x) - w, getMapping(y) + h);
	}
	
	public void drawStringRB(Graphics g, String str, int x, int y){
		
		//g.setFont(new Font("Arial", Font.BOLD, 24));
		//g.setColor(Color.white);
		
		FontMetrics fm = g.getFontMetrics();
		int w = fm.stringWidth(str);
		//int h = fm.getAscent() - fm.getDescent() - fm.getLeading();
		g.drawString(str, getMapping(x) - w, getMapping(y));
	}
	
	public void drawStringCT(Graphics g, String str, int x, int y){
		FontMetrics fm = g.getFontMetrics();
		int w = fm.stringWidth(str);
		int h = fm.getAscent() - fm.getDescent() - fm.getLeading();
		g.drawString(str, getMapping(x) - w/2, getMapping(y) + h);
	}







}