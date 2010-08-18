




/*
'===============================================================================
'  LinqHelper.DAO.NgheNghiepDoiTuongBase
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
	public class LqNgheNghiepDoiTuongBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqNgheNghiepDoiTuongBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqNgheNghiepDoiTuongEntity obj)
		{
			provider.GetTable<LqNgheNghiepDoiTuongEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqNgheNghiepDoiTuongEntity _obj)
		{
			var q = from obj in provider.GetTable<LqNgheNghiepDoiTuongEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqNgheNghiepDoiTuongEntity tmp = q.First<LqNgheNghiepDoiTuongEntity>();
			
			tmp.IdLoaiCoQuan = _obj.IdLoaiCoQuan;
			tmp.IdNgheNghiep = _obj.IdNgheNghiep;
			tmp.IdDoiTuong = _obj.IdDoiTuong;
			tmp.IdChucVu = _obj.IdChucVu;
			tmp.NoiLamViec = _obj.NoiLamViec;
			tmp.TinhTrangNgheNghiep = _obj.TinhTrangNgheNghiep;
			tmp.TongHop = _obj.TongHop;
			tmp.GhiChu = _obj.GhiChu;
			tmp.MaRutGon = _obj.MaRutGon;
			tmp.MaTp = _obj.MaTp;
			tmp.LoaiDanhMuc = _obj.LoaiDanhMuc;
			tmp.IdNguoiTao = _obj.IdNguoiTao;
			tmp.NgayTao = _obj.NgayTao;
			tmp.IdNguoiCapNhat = _obj.IdNguoiCapNhat;
			tmp.NgayCapNhat = _obj.NgayCapNhat;
			tmp.NgayHetHan = _obj.NgayHetHan;
			tmp.TrangThai = _obj.TrangThai;
		}
		
		public void Delete(LqNgheNghiepDoiTuongEntity obj)
		{
			provider.GetTable<LqNgheNghiepDoiTuongEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqNgheNghiepDoiTuongEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqNgheNghiepDoiTuongEntity ob = (LqNgheNghiepDoiTuongEntity)q.First<LqNgheNghiepDoiTuongEntity>();
            provider.GetTable<LqNgheNghiepDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdLoaiCoQuan(Guid IdLoaiCoQuan)
		{
			var q = from obj in provider.GetTable<LqNgheNghiepDoiTuongEntity>()
                    where obj.IdLoaiCoQuan.Value == IdLoaiCoQuan
                    select obj;
					
            LqNgheNghiepDoiTuongEntity ob = (LqNgheNghiepDoiTuongEntity)q.First<LqNgheNghiepDoiTuongEntity>();
            provider.GetTable<LqNgheNghiepDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNgheNghiep(Guid IdNgheNghiep)
		{
			var q = from obj in provider.GetTable<LqNgheNghiepDoiTuongEntity>()
                    where obj.IdNgheNghiep.Value == IdNgheNghiep
                    select obj;
					
            LqNgheNghiepDoiTuongEntity ob = (LqNgheNghiepDoiTuongEntity)q.First<LqNgheNghiepDoiTuongEntity>();
            provider.GetTable<LqNgheNghiepDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdDoiTuong(Guid IdDoiTuong)
		{
			var q = from obj in provider.GetTable<LqNgheNghiepDoiTuongEntity>()
                    where obj.IdDoiTuong.Value == IdDoiTuong
                    select obj;
					
            LqNgheNghiepDoiTuongEntity ob = (LqNgheNghiepDoiTuongEntity)q.First<LqNgheNghiepDoiTuongEntity>();
            provider.GetTable<LqNgheNghiepDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdChucVu(Guid IdChucVu)
		{
			var q = from obj in provider.GetTable<LqNgheNghiepDoiTuongEntity>()
                    where obj.IdChucVu.Value == IdChucVu
                    select obj;
					
            LqNgheNghiepDoiTuongEntity ob = (LqNgheNghiepDoiTuongEntity)q.First<LqNgheNghiepDoiTuongEntity>();
            provider.GetTable<LqNgheNghiepDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNoiLamViec(string NoiLamViec)
		{
			var q = from obj in provider.GetTable<LqNgheNghiepDoiTuongEntity>()
                    where obj.NoiLamViec == NoiLamViec
                    select obj;
					
            LqNgheNghiepDoiTuongEntity ob = (LqNgheNghiepDoiTuongEntity)q.First<LqNgheNghiepDoiTuongEntity>();
            provider.GetTable<LqNgheNghiepDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTinhTrangNgheNghiep(string TinhTrangNgheNghiep)
		{
			var q = from obj in provider.GetTable<LqNgheNghiepDoiTuongEntity>()
                    where obj.TinhTrangNgheNghiep == TinhTrangNgheNghiep
                    select obj;
					
            LqNgheNghiepDoiTuongEntity ob = (LqNgheNghiepDoiTuongEntity)q.First<LqNgheNghiepDoiTuongEntity>();
            provider.GetTable<LqNgheNghiepDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTongHop(string TongHop)
		{
			var q = from obj in provider.GetTable<LqNgheNghiepDoiTuongEntity>()
                    where obj.TongHop == TongHop
                    select obj;
					
            LqNgheNghiepDoiTuongEntity ob = (LqNgheNghiepDoiTuongEntity)q.First<LqNgheNghiepDoiTuongEntity>();
            provider.GetTable<LqNgheNghiepDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqNgheNghiepDoiTuongEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqNgheNghiepDoiTuongEntity ob = (LqNgheNghiepDoiTuongEntity)q.First<LqNgheNghiepDoiTuongEntity>();
            provider.GetTable<LqNgheNghiepDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqNgheNghiepDoiTuongEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqNgheNghiepDoiTuongEntity ob = (LqNgheNghiepDoiTuongEntity)q.First<LqNgheNghiepDoiTuongEntity>();
            provider.GetTable<LqNgheNghiepDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqNgheNghiepDoiTuongEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqNgheNghiepDoiTuongEntity ob = (LqNgheNghiepDoiTuongEntity)q.First<LqNgheNghiepDoiTuongEntity>();
            provider.GetTable<LqNgheNghiepDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqNgheNghiepDoiTuongEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqNgheNghiepDoiTuongEntity ob = (LqNgheNghiepDoiTuongEntity)q.First<LqNgheNghiepDoiTuongEntity>();
            provider.GetTable<LqNgheNghiepDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqNgheNghiepDoiTuongEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqNgheNghiepDoiTuongEntity ob = (LqNgheNghiepDoiTuongEntity)q.First<LqNgheNghiepDoiTuongEntity>();
            provider.GetTable<LqNgheNghiepDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqNgheNghiepDoiTuongEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqNgheNghiepDoiTuongEntity ob = (LqNgheNghiepDoiTuongEntity)q.First<LqNgheNghiepDoiTuongEntity>();
            provider.GetTable<LqNgheNghiepDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqNgheNghiepDoiTuongEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqNgheNghiepDoiTuongEntity ob = (LqNgheNghiepDoiTuongEntity)q.First<LqNgheNghiepDoiTuongEntity>();
            provider.GetTable<LqNgheNghiepDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqNgheNghiepDoiTuongEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqNgheNghiepDoiTuongEntity ob = (LqNgheNghiepDoiTuongEntity)q.First<LqNgheNghiepDoiTuongEntity>();
            provider.GetTable<LqNgheNghiepDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqNgheNghiepDoiTuongEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqNgheNghiepDoiTuongEntity ob = (LqNgheNghiepDoiTuongEntity)q.First<LqNgheNghiepDoiTuongEntity>();
            provider.GetTable<LqNgheNghiepDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqNgheNghiepDoiTuongEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqNgheNghiepDoiTuongEntity ob = (LqNgheNghiepDoiTuongEntity)q.First<LqNgheNghiepDoiTuongEntity>();
            provider.GetTable<LqNgheNghiepDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqNgheNghiepDoiTuongEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqNgheNghiepDoiTuongEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqNgheNghiepDoiTuongEntity>();
		}

		public List<LqNgheNghiepDoiTuongEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqNgheNghiepDoiTuongEntity>()
                        select obj;
            return query.ToList<LqNgheNghiepDoiTuongEntity>();
		}
		
		
		public List<LqNgheNghiepDoiTuongEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqNgheNghiepDoiTuongEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqNgheNghiepDoiTuongEntity>();
		}
		
		
		public List<LqNgheNghiepDoiTuongEntity> SelectByIdLoaiCoQuan(Guid IdLoaiCoQuan)
		{
			var query = from obj in provider.GetTable<LqNgheNghiepDoiTuongEntity>()
                        where obj.IdLoaiCoQuan.Value == IdLoaiCoQuan
                        select obj;
            return query.ToList<LqNgheNghiepDoiTuongEntity>();
		}
		
		
		public List<LqNgheNghiepDoiTuongEntity> SelectByIdNgheNghiep(Guid IdNgheNghiep)
		{
			var query = from obj in provider.GetTable<LqNgheNghiepDoiTuongEntity>()
                        where obj.IdNgheNghiep.Value == IdNgheNghiep
                        select obj;
            return query.ToList<LqNgheNghiepDoiTuongEntity>();
		}
		
		
		public List<LqNgheNghiepDoiTuongEntity> SelectByIdDoiTuong(Guid IdDoiTuong)
		{
			var query = from obj in provider.GetTable<LqNgheNghiepDoiTuongEntity>()
                        where obj.IdDoiTuong.Value == IdDoiTuong
                        select obj;
            return query.ToList<LqNgheNghiepDoiTuongEntity>();
		}
		
		
		public List<LqNgheNghiepDoiTuongEntity> SelectByIdChucVu(Guid IdChucVu)
		{
			var query = from obj in provider.GetTable<LqNgheNghiepDoiTuongEntity>()
                        where obj.IdChucVu.Value == IdChucVu
                        select obj;
            return query.ToList<LqNgheNghiepDoiTuongEntity>();
		}
		
		
		public List<LqNgheNghiepDoiTuongEntity> SelectByNoiLamViec(string NoiLamViec)
		{
			var query = from obj in provider.GetTable<LqNgheNghiepDoiTuongEntity>()
                        where obj.NoiLamViec == NoiLamViec
                        select obj;
            return query.ToList<LqNgheNghiepDoiTuongEntity>();
		}
		
		
		public List<LqNgheNghiepDoiTuongEntity> SelectByTinhTrangNgheNghiep(string TinhTrangNgheNghiep)
		{
			var query = from obj in provider.GetTable<LqNgheNghiepDoiTuongEntity>()
                        where obj.TinhTrangNgheNghiep == TinhTrangNgheNghiep
                        select obj;
            return query.ToList<LqNgheNghiepDoiTuongEntity>();
		}
		
		
		public List<LqNgheNghiepDoiTuongEntity> SelectByTongHop(string TongHop)
		{
			var query = from obj in provider.GetTable<LqNgheNghiepDoiTuongEntity>()
                        where obj.TongHop == TongHop
                        select obj;
            return query.ToList<LqNgheNghiepDoiTuongEntity>();
		}
		
		
		public List<LqNgheNghiepDoiTuongEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqNgheNghiepDoiTuongEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqNgheNghiepDoiTuongEntity>();
		}
		
		
		public List<LqNgheNghiepDoiTuongEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqNgheNghiepDoiTuongEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqNgheNghiepDoiTuongEntity>();
		}
		
		
		public List<LqNgheNghiepDoiTuongEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqNgheNghiepDoiTuongEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqNgheNghiepDoiTuongEntity>();
		}
		
		
		public List<LqNgheNghiepDoiTuongEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqNgheNghiepDoiTuongEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqNgheNghiepDoiTuongEntity>();
		}
		
		
		public List<LqNgheNghiepDoiTuongEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqNgheNghiepDoiTuongEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqNgheNghiepDoiTuongEntity>();
		}
		
		
		public List<LqNgheNghiepDoiTuongEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqNgheNghiepDoiTuongEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqNgheNghiepDoiTuongEntity>();
		}
		
		
		public List<LqNgheNghiepDoiTuongEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqNgheNghiepDoiTuongEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqNgheNghiepDoiTuongEntity>();
		}
		
		
		public List<LqNgheNghiepDoiTuongEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqNgheNghiepDoiTuongEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqNgheNghiepDoiTuongEntity>();
		}
		
		
		public List<LqNgheNghiepDoiTuongEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqNgheNghiepDoiTuongEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqNgheNghiepDoiTuongEntity>();
		}
		
		
		public List<LqNgheNghiepDoiTuongEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqNgheNghiepDoiTuongEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqNgheNghiepDoiTuongEntity>();
		}
		
		
		

	}
}
