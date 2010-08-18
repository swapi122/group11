




/*
'===============================================================================
'  LinqHelper.DAO.DiaBanBase
'===============================================================================
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using LinqHelper;
using LinqHelper.Entity;
using LinqHelper.DAO;

namespace LinqHelper.DAO
{
	public class LqDiaBanBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqDiaBanBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqDiaBanEntity obj)
		{
			provider.GetTable<LqDiaBanEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqDiaBanEntity _obj)
		{
			var q = from obj in provider.GetTable<LqDiaBanEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqDiaBanEntity tmp = q.First<LqDiaBanEntity>();
			
			tmp.TenDiaBan = _obj.TenDiaBan;
			tmp.MaRutGon = _obj.MaRutGon;
			tmp.SoHoSo = _obj.SoHoSo;
			tmp.DiaBanBaoVe = _obj.DiaBanBaoVe;
			tmp.MucTieuPhanGian = _obj.MucTieuPhanGian;
			tmp.IdHuyen = _obj.IdHuyen;
			tmp.IdXa = _obj.IdXa;
			tmp.IdThon = _obj.IdThon;
			tmp.Duong = _obj.Duong;
			tmp.SoNha = _obj.SoNha;
			tmp.IdOkhuVuc = _obj.IdOkhuVuc;
			tmp.IdToDanPho = _obj.IdToDanPho;
			tmp.CoQuanChuQuanCapTren = _obj.CoQuanChuQuanCapTren;
			tmp.DienThoai = _obj.DienThoai;
			tmp.NguoiDungDauMucTieu = _obj.NguoiDungDauMucTieu;
			tmp.DtddnguoiDungDauMucTieu = _obj.DtddnguoiDungDauMucTieu;
			tmp.DtbanNguoiDungDauMucTieu = _obj.DtbanNguoiDungDauMucTieu;
			tmp.NguoiDungDauBaoVe = _obj.NguoiDungDauBaoVe;
			tmp.DtddnguoiDungDauBaoVe = _obj.DtddnguoiDungDauBaoVe;
			tmp.DtbanNguoiDungDauBaoVe = _obj.DtbanNguoiDungDauBaoVe;
			tmp.Antt = _obj.Antt;
			tmp.CongTacTrienKhai = _obj.CongTacTrienKhai;
			tmp.GhiChu = _obj.GhiChu;
			tmp.TongSoNhanSu = _obj.TongSoNhanSu;
			tmp.DanhSachNhanSu = _obj.DanhSachNhanSu;
			tmp.IdNguoiTao = _obj.IdNguoiTao;
			tmp.NgayTao = _obj.NgayTao;
			tmp.IdNguoiCapNhat = _obj.IdNguoiCapNhat;
			tmp.NgayCapNhat = _obj.NgayCapNhat;
			tmp.TrangThai = _obj.TrangThai;
		}
		
		public void Delete(LqDiaBanEntity obj)
		{
			provider.GetTable<LqDiaBanEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqDiaBanEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqDiaBanEntity ob = (LqDiaBanEntity)q.First<LqDiaBanEntity>();
            provider.GetTable<LqDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenDiaBan(string TenDiaBan)
		{
			var q = from obj in provider.GetTable<LqDiaBanEntity>()
                    where obj.TenDiaBan == TenDiaBan
                    select obj;
					
            LqDiaBanEntity ob = (LqDiaBanEntity)q.First<LqDiaBanEntity>();
            provider.GetTable<LqDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqDiaBanEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqDiaBanEntity ob = (LqDiaBanEntity)q.First<LqDiaBanEntity>();
            provider.GetTable<LqDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteBySoHoSo(string SoHoSo)
		{
			var q = from obj in provider.GetTable<LqDiaBanEntity>()
                    where obj.SoHoSo == SoHoSo
                    select obj;
					
            LqDiaBanEntity ob = (LqDiaBanEntity)q.First<LqDiaBanEntity>();
            provider.GetTable<LqDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByDiaBanBaoVe(string DiaBanBaoVe)
		{
			var q = from obj in provider.GetTable<LqDiaBanEntity>()
                    where obj.DiaBanBaoVe == DiaBanBaoVe
                    select obj;
					
            LqDiaBanEntity ob = (LqDiaBanEntity)q.First<LqDiaBanEntity>();
            provider.GetTable<LqDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMucTieuPhanGian(string MucTieuPhanGian)
		{
			var q = from obj in provider.GetTable<LqDiaBanEntity>()
                    where obj.MucTieuPhanGian == MucTieuPhanGian
                    select obj;
					
            LqDiaBanEntity ob = (LqDiaBanEntity)q.First<LqDiaBanEntity>();
            provider.GetTable<LqDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdHuyen(Guid IdHuyen)
		{
			var q = from obj in provider.GetTable<LqDiaBanEntity>()
                    where obj.IdHuyen.Value == IdHuyen
                    select obj;
					
            LqDiaBanEntity ob = (LqDiaBanEntity)q.First<LqDiaBanEntity>();
            provider.GetTable<LqDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdXa(Guid IdXa)
		{
			var q = from obj in provider.GetTable<LqDiaBanEntity>()
                    where obj.IdXa.Value == IdXa
                    select obj;
					
            LqDiaBanEntity ob = (LqDiaBanEntity)q.First<LqDiaBanEntity>();
            provider.GetTable<LqDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdThon(Guid IdThon)
		{
			var q = from obj in provider.GetTable<LqDiaBanEntity>()
                    where obj.IdThon.Value == IdThon
                    select obj;
					
            LqDiaBanEntity ob = (LqDiaBanEntity)q.First<LqDiaBanEntity>();
            provider.GetTable<LqDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByDuong(string Duong)
		{
			var q = from obj in provider.GetTable<LqDiaBanEntity>()
                    where obj.Duong == Duong
                    select obj;
					
            LqDiaBanEntity ob = (LqDiaBanEntity)q.First<LqDiaBanEntity>();
            provider.GetTable<LqDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteBySoNha(string SoNha)
		{
			var q = from obj in provider.GetTable<LqDiaBanEntity>()
                    where obj.SoNha == SoNha
                    select obj;
					
            LqDiaBanEntity ob = (LqDiaBanEntity)q.First<LqDiaBanEntity>();
            provider.GetTable<LqDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdOkhuVuc(Guid IdOkhuVuc)
		{
			var q = from obj in provider.GetTable<LqDiaBanEntity>()
                    where obj.IdOkhuVuc.Value == IdOkhuVuc
                    select obj;
					
            LqDiaBanEntity ob = (LqDiaBanEntity)q.First<LqDiaBanEntity>();
            provider.GetTable<LqDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdToDanPho(Guid IdToDanPho)
		{
			var q = from obj in provider.GetTable<LqDiaBanEntity>()
                    where obj.IdToDanPho.Value == IdToDanPho
                    select obj;
					
            LqDiaBanEntity ob = (LqDiaBanEntity)q.First<LqDiaBanEntity>();
            provider.GetTable<LqDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByCoQuanChuQuanCapTren(string CoQuanChuQuanCapTren)
		{
			var q = from obj in provider.GetTable<LqDiaBanEntity>()
                    where obj.CoQuanChuQuanCapTren == CoQuanChuQuanCapTren
                    select obj;
					
            LqDiaBanEntity ob = (LqDiaBanEntity)q.First<LqDiaBanEntity>();
            provider.GetTable<LqDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByDienThoai(string DienThoai)
		{
			var q = from obj in provider.GetTable<LqDiaBanEntity>()
                    where obj.DienThoai == DienThoai
                    select obj;
					
            LqDiaBanEntity ob = (LqDiaBanEntity)q.First<LqDiaBanEntity>();
            provider.GetTable<LqDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNguoiDungDauMucTieu(string NguoiDungDauMucTieu)
		{
			var q = from obj in provider.GetTable<LqDiaBanEntity>()
                    where obj.NguoiDungDauMucTieu == NguoiDungDauMucTieu
                    select obj;
					
            LqDiaBanEntity ob = (LqDiaBanEntity)q.First<LqDiaBanEntity>();
            provider.GetTable<LqDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByDtddnguoiDungDauMucTieu(string DtddnguoiDungDauMucTieu)
		{
			var q = from obj in provider.GetTable<LqDiaBanEntity>()
                    where obj.DtddnguoiDungDauMucTieu == DtddnguoiDungDauMucTieu
                    select obj;
					
            LqDiaBanEntity ob = (LqDiaBanEntity)q.First<LqDiaBanEntity>();
            provider.GetTable<LqDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByDtbanNguoiDungDauMucTieu(string DtbanNguoiDungDauMucTieu)
		{
			var q = from obj in provider.GetTable<LqDiaBanEntity>()
                    where obj.DtbanNguoiDungDauMucTieu == DtbanNguoiDungDauMucTieu
                    select obj;
					
            LqDiaBanEntity ob = (LqDiaBanEntity)q.First<LqDiaBanEntity>();
            provider.GetTable<LqDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNguoiDungDauBaoVe(string NguoiDungDauBaoVe)
		{
			var q = from obj in provider.GetTable<LqDiaBanEntity>()
                    where obj.NguoiDungDauBaoVe == NguoiDungDauBaoVe
                    select obj;
					
            LqDiaBanEntity ob = (LqDiaBanEntity)q.First<LqDiaBanEntity>();
            provider.GetTable<LqDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByDtddnguoiDungDauBaoVe(string DtddnguoiDungDauBaoVe)
		{
			var q = from obj in provider.GetTable<LqDiaBanEntity>()
                    where obj.DtddnguoiDungDauBaoVe == DtddnguoiDungDauBaoVe
                    select obj;
					
            LqDiaBanEntity ob = (LqDiaBanEntity)q.First<LqDiaBanEntity>();
            provider.GetTable<LqDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByDtbanNguoiDungDauBaoVe(string DtbanNguoiDungDauBaoVe)
		{
			var q = from obj in provider.GetTable<LqDiaBanEntity>()
                    where obj.DtbanNguoiDungDauBaoVe == DtbanNguoiDungDauBaoVe
                    select obj;
					
            LqDiaBanEntity ob = (LqDiaBanEntity)q.First<LqDiaBanEntity>();
            provider.GetTable<LqDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByAntt(string Antt)
		{
			var q = from obj in provider.GetTable<LqDiaBanEntity>()
                    where obj.Antt == Antt
                    select obj;
					
            LqDiaBanEntity ob = (LqDiaBanEntity)q.First<LqDiaBanEntity>();
            provider.GetTable<LqDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByCongTacTrienKhai(string CongTacTrienKhai)
		{
			var q = from obj in provider.GetTable<LqDiaBanEntity>()
                    where obj.CongTacTrienKhai == CongTacTrienKhai
                    select obj;
					
            LqDiaBanEntity ob = (LqDiaBanEntity)q.First<LqDiaBanEntity>();
            provider.GetTable<LqDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqDiaBanEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqDiaBanEntity ob = (LqDiaBanEntity)q.First<LqDiaBanEntity>();
            provider.GetTable<LqDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTongSoNhanSu(string TongSoNhanSu)
		{
			var q = from obj in provider.GetTable<LqDiaBanEntity>()
                    where obj.TongSoNhanSu == TongSoNhanSu
                    select obj;
					
            LqDiaBanEntity ob = (LqDiaBanEntity)q.First<LqDiaBanEntity>();
            provider.GetTable<LqDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByDanhSachNhanSu(string DanhSachNhanSu)
		{
			var q = from obj in provider.GetTable<LqDiaBanEntity>()
                    where obj.DanhSachNhanSu == DanhSachNhanSu
                    select obj;
					
            LqDiaBanEntity ob = (LqDiaBanEntity)q.First<LqDiaBanEntity>();
            provider.GetTable<LqDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqDiaBanEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqDiaBanEntity ob = (LqDiaBanEntity)q.First<LqDiaBanEntity>();
            provider.GetTable<LqDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqDiaBanEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqDiaBanEntity ob = (LqDiaBanEntity)q.First<LqDiaBanEntity>();
            provider.GetTable<LqDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqDiaBanEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqDiaBanEntity ob = (LqDiaBanEntity)q.First<LqDiaBanEntity>();
            provider.GetTable<LqDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqDiaBanEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqDiaBanEntity ob = (LqDiaBanEntity)q.First<LqDiaBanEntity>();
            provider.GetTable<LqDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqDiaBanEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqDiaBanEntity ob = (LqDiaBanEntity)q.First<LqDiaBanEntity>();
            provider.GetTable<LqDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqDiaBanEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqDiaBanEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqDiaBanEntity>();
		}

		public List<LqDiaBanEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqDiaBanEntity>()
                        select obj;
            return query.ToList<LqDiaBanEntity>();
		}
		
		
		public List<LqDiaBanEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqDiaBanEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqDiaBanEntity>();
		}
		
		
		public List<LqDiaBanEntity> SelectByTenDiaBan(string TenDiaBan)
		{
			var query = from obj in provider.GetTable<LqDiaBanEntity>()
                        where obj.TenDiaBan == TenDiaBan
                        select obj;
            return query.ToList<LqDiaBanEntity>();
		}
		
		
		public List<LqDiaBanEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqDiaBanEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqDiaBanEntity>();
		}
		
		
		public List<LqDiaBanEntity> SelectBySoHoSo(string SoHoSo)
		{
			var query = from obj in provider.GetTable<LqDiaBanEntity>()
                        where obj.SoHoSo == SoHoSo
                        select obj;
            return query.ToList<LqDiaBanEntity>();
		}
		
		
		public List<LqDiaBanEntity> SelectByDiaBanBaoVe(string DiaBanBaoVe)
		{
			var query = from obj in provider.GetTable<LqDiaBanEntity>()
                        where obj.DiaBanBaoVe == DiaBanBaoVe
                        select obj;
            return query.ToList<LqDiaBanEntity>();
		}
		
		
		public List<LqDiaBanEntity> SelectByMucTieuPhanGian(string MucTieuPhanGian)
		{
			var query = from obj in provider.GetTable<LqDiaBanEntity>()
                        where obj.MucTieuPhanGian == MucTieuPhanGian
                        select obj;
            return query.ToList<LqDiaBanEntity>();
		}
		
		
		public List<LqDiaBanEntity> SelectByIdHuyen(Guid IdHuyen)
		{
			var query = from obj in provider.GetTable<LqDiaBanEntity>()
                        where obj.IdHuyen.Value == IdHuyen
                        select obj;
            return query.ToList<LqDiaBanEntity>();
		}
		
		
		public List<LqDiaBanEntity> SelectByIdXa(Guid IdXa)
		{
			var query = from obj in provider.GetTable<LqDiaBanEntity>()
                        where obj.IdXa.Value == IdXa
                        select obj;
            return query.ToList<LqDiaBanEntity>();
		}
		
		
		public List<LqDiaBanEntity> SelectByIdThon(Guid IdThon)
		{
			var query = from obj in provider.GetTable<LqDiaBanEntity>()
                        where obj.IdThon.Value == IdThon
                        select obj;
            return query.ToList<LqDiaBanEntity>();
		}
		
		
		public List<LqDiaBanEntity> SelectByDuong(string Duong)
		{
			var query = from obj in provider.GetTable<LqDiaBanEntity>()
                        where obj.Duong == Duong
                        select obj;
            return query.ToList<LqDiaBanEntity>();
		}
		
		
		public List<LqDiaBanEntity> SelectBySoNha(string SoNha)
		{
			var query = from obj in provider.GetTable<LqDiaBanEntity>()
                        where obj.SoNha == SoNha
                        select obj;
            return query.ToList<LqDiaBanEntity>();
		}
		
		
		public List<LqDiaBanEntity> SelectByIdOkhuVuc(Guid IdOkhuVuc)
		{
			var query = from obj in provider.GetTable<LqDiaBanEntity>()
                        where obj.IdOkhuVuc.Value == IdOkhuVuc
                        select obj;
            return query.ToList<LqDiaBanEntity>();
		}
		
		
		public List<LqDiaBanEntity> SelectByIdToDanPho(Guid IdToDanPho)
		{
			var query = from obj in provider.GetTable<LqDiaBanEntity>()
                        where obj.IdToDanPho.Value == IdToDanPho
                        select obj;
            return query.ToList<LqDiaBanEntity>();
		}
		
		
		public List<LqDiaBanEntity> SelectByCoQuanChuQuanCapTren(string CoQuanChuQuanCapTren)
		{
			var query = from obj in provider.GetTable<LqDiaBanEntity>()
                        where obj.CoQuanChuQuanCapTren == CoQuanChuQuanCapTren
                        select obj;
            return query.ToList<LqDiaBanEntity>();
		}
		
		
		public List<LqDiaBanEntity> SelectByDienThoai(string DienThoai)
		{
			var query = from obj in provider.GetTable<LqDiaBanEntity>()
                        where obj.DienThoai == DienThoai
                        select obj;
            return query.ToList<LqDiaBanEntity>();
		}
		
		
		public List<LqDiaBanEntity> SelectByNguoiDungDauMucTieu(string NguoiDungDauMucTieu)
		{
			var query = from obj in provider.GetTable<LqDiaBanEntity>()
                        where obj.NguoiDungDauMucTieu == NguoiDungDauMucTieu
                        select obj;
            return query.ToList<LqDiaBanEntity>();
		}
		
		
		public List<LqDiaBanEntity> SelectByDtddnguoiDungDauMucTieu(string DtddnguoiDungDauMucTieu)
		{
			var query = from obj in provider.GetTable<LqDiaBanEntity>()
                        where obj.DtddnguoiDungDauMucTieu == DtddnguoiDungDauMucTieu
                        select obj;
            return query.ToList<LqDiaBanEntity>();
		}
		
		
		public List<LqDiaBanEntity> SelectByDtbanNguoiDungDauMucTieu(string DtbanNguoiDungDauMucTieu)
		{
			var query = from obj in provider.GetTable<LqDiaBanEntity>()
                        where obj.DtbanNguoiDungDauMucTieu == DtbanNguoiDungDauMucTieu
                        select obj;
            return query.ToList<LqDiaBanEntity>();
		}
		
		
		public List<LqDiaBanEntity> SelectByNguoiDungDauBaoVe(string NguoiDungDauBaoVe)
		{
			var query = from obj in provider.GetTable<LqDiaBanEntity>()
                        where obj.NguoiDungDauBaoVe == NguoiDungDauBaoVe
                        select obj;
            return query.ToList<LqDiaBanEntity>();
		}
		
		
		public List<LqDiaBanEntity> SelectByDtddnguoiDungDauBaoVe(string DtddnguoiDungDauBaoVe)
		{
			var query = from obj in provider.GetTable<LqDiaBanEntity>()
                        where obj.DtddnguoiDungDauBaoVe == DtddnguoiDungDauBaoVe
                        select obj;
            return query.ToList<LqDiaBanEntity>();
		}
		
		
		public List<LqDiaBanEntity> SelectByDtbanNguoiDungDauBaoVe(string DtbanNguoiDungDauBaoVe)
		{
			var query = from obj in provider.GetTable<LqDiaBanEntity>()
                        where obj.DtbanNguoiDungDauBaoVe == DtbanNguoiDungDauBaoVe
                        select obj;
            return query.ToList<LqDiaBanEntity>();
		}
		
		
		public List<LqDiaBanEntity> SelectByAntt(string Antt)
		{
			var query = from obj in provider.GetTable<LqDiaBanEntity>()
                        where obj.Antt == Antt
                        select obj;
            return query.ToList<LqDiaBanEntity>();
		}
		
		
		public List<LqDiaBanEntity> SelectByCongTacTrienKhai(string CongTacTrienKhai)
		{
			var query = from obj in provider.GetTable<LqDiaBanEntity>()
                        where obj.CongTacTrienKhai == CongTacTrienKhai
                        select obj;
            return query.ToList<LqDiaBanEntity>();
		}
		
		
		public List<LqDiaBanEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqDiaBanEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqDiaBanEntity>();
		}
		
		
		public List<LqDiaBanEntity> SelectByTongSoNhanSu(string TongSoNhanSu)
		{
			var query = from obj in provider.GetTable<LqDiaBanEntity>()
                        where obj.TongSoNhanSu == TongSoNhanSu
                        select obj;
            return query.ToList<LqDiaBanEntity>();
		}
		
		
		public List<LqDiaBanEntity> SelectByDanhSachNhanSu(string DanhSachNhanSu)
		{
			var query = from obj in provider.GetTable<LqDiaBanEntity>()
                        where obj.DanhSachNhanSu == DanhSachNhanSu
                        select obj;
            return query.ToList<LqDiaBanEntity>();
		}
		
		
		public List<LqDiaBanEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqDiaBanEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqDiaBanEntity>();
		}
		
		
		public List<LqDiaBanEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqDiaBanEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqDiaBanEntity>();
		}
		
		
		public List<LqDiaBanEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqDiaBanEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqDiaBanEntity>();
		}
		
		
		public List<LqDiaBanEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqDiaBanEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqDiaBanEntity>();
		}
		
		
		public List<LqDiaBanEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqDiaBanEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqDiaBanEntity>();
		}
		
		
		

	}
}
